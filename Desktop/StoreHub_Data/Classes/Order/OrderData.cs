using Azure;
using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Classes.Order
{
    public class OrderData
    {

        public static async Task<int> PlaceOrder(DTO_OrderPlace order)
        {

            try
            {
                using var context = Settings.CreateContext();

                using var transaction = await context.Database.BeginTransactionAsync();
                
                try
                {

                    var newOrder = new Entities.Order
                    {
                        PersonId = order.PersonID,
                        ShippingAddress = order.ShippingAddress,
                        TotalAmount = order.TotalAmount,
                        OrderStatusId = 1
                    };

                    await context.Orders.AddAsync(newOrder);

                    await context.SaveChangesAsync();

                    var orderId = newOrder.OrderId;

                    var cart = await context.Carts.Where(c => c.PersonId == order.PersonID)
                     .Select(c => new
                     {
                         c.PersonId,
                         c.CartId,
                         Items = c.Items.Select(i => new
                         {
                             i.ProductId, i.Quantity,i.Product.Price
                         })
                     }).FirstOrDefaultAsync();

                    var orderItems = cart.Items
                        .Select(item => new Entities.OrderItem
                        {
                            OrderId = orderId,
                            ProductId = item.ProductId,
                            Quantity = item.Quantity,
                            UnitPrice = item.Price

                        }).ToList();


                    context.OrderItems.AddRange(orderItems);

                    foreach (var item in cart.Items)
                    {
                        int affected = await context.Products
                            .Where(p => p.ProductId == item.ProductId &&
                                        p.StockQuantity >= item.Quantity)
                            .ExecuteUpdateAsync(p => p
                                .SetProperty(x => x.StockQuantity,
                                             x => x.StockQuantity - item.Quantity));

                        if (affected == 0)
                            throw new Exception("Not enough stock.");
                    }


                    context.CartItems.Where(i =>  i.CartId == cart.CartId).ExecuteDelete();


                    await context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return orderId;

                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }

            }
            catch
            {
                throw;
            }

        }

        public static async Task<DTO_MyOrdersResponse> ViewMyOrders(DTO_OrderViewMyRequest request)
        {

                using var context = Settings.CreateContext();

            DTO_MyOrdersResponse response = new DTO_MyOrdersResponse();


            var query = context.Orders
        .Where(r => r.PersonId == request.PersonId)
        .AsNoTracking();

            

            var orders = await query.OrderBy(p => p.OrderStatusId)
                .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize).Select(p => new DTO_OrderSummary
                    {
                        OrderNumber = p.OrderId,
                        TotalAmount = p.TotalAmount,
                        ItemsCount = p.Items.Count,
                        OrderStatusId = p.OrderStatusId,
                        OrderDate = p.OrderDate
                    }).ToListAsync();


            response.Orders = orders;
            response.AvalibleOrdersCount = await query.CountAsync();
            response.LastPageNumber = (int)Math.Ceiling((double)response.AvalibleOrdersCount / request.PageSize);
            response.HasNextPage = await query
            .Skip(request.PageNumber * request.PageSize)
            .AnyAsync();

            return response;


        }


        public static async Task<DTO_OrderDetails> GetOrdersDetails(int orderId)
        {
            using var context = Settings.CreateContext();


            var order = await context.Orders.Where(o => o.OrderId == orderId)
            .Select(o => new DTO_OrderDetails
            {
                Items = o.Items.Select(i => new DTO_OrderItem
                {
                    ProductID = i.ProductId,
                    UnitPrice = i.UnitPrice,
                    OrderItemId = i.OrderItemId,
                    Quantity = i.Quantity,
                    ProductName = i.Product.Name,
                    ImagePath = i.Product.ProductImages.Select(img => img.ImagePath).FirstOrDefault(),
                }).ToList(),
                ShippingAddress = o.ShippingAddress,
                OrderDate = o.OrderDate,
                OrderID = o.OrderId,
                OrderStatusID = o.OrderStatusId,
                TotalAmount = o.TotalAmount
            }
            
            ).FirstOrDefaultAsync();



            return order; 

        }

        public static async Task<bool> CancelOrder(int orderId)
        {
            using var context = Settings.CreateContext();


            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {

                var items = await context.OrderItems.Where(o => o.OrderId == orderId).Select(o => new {o.ProductId,o.Quantity}).ToListAsync();

                foreach(var item in items)
                {
                    await context.Products
                    .Where(p => p.ProductId == item.ProductId)
                    .ExecuteUpdateAsync(p => p
                    .SetProperty(
                    x => x.StockQuantity,
                    x => x.StockQuantity + item.Quantity));
                }

                int rows = await context.Orders.Where(o => o.OrderId == orderId && o.OrderStatusId == 1).ExecuteUpdateAsync(o => o.SetProperty(o => o.OrderStatusId, 6));

                if(rows == 0)
                        throw new Exception("Only pending orders can be cancelled.");

                await transaction.CommitAsync();

                return true;
            }
            catch
            {
                transaction.Rollback();



                return false;
            }



        }

        public static async Task<bool> ChangeOrderStatus(DTO_OrderChangeStatus requst)
        {
            using var context = Settings.CreateContext();

            if(requst.StatusId == 6)
            {
                return await CancelOrder(requst.OrderId);
            }

            try
            {

                int rows = await context.Orders.Where(o => o.OrderId == requst.OrderId).ExecuteUpdateAsync(o => o.SetProperty(o => o.OrderStatusId, requst.StatusId));

                return rows >0;
            }
            catch
            {
                return false;
            }
        }



    }
}
