using Azure.Core;
using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Classes.Seller
{
    public class clsSellerData
    {


        public static async Task<int> CreateStore(DTO_SellerCreateStoreRequest request)
        {

            try
            {
                using var context = Settings.CreateContext();

                using var transaction = await context.Database.BeginTransactionAsync();

                try
                {

                    var newStore = new Entities.Store
                    {
                        PersonId = request.PersonId,
                        StoreName = request.StoreName,
                        StoreDescription = request.Description
                    };

                    await context.Stores.AddAsync(newStore);

                    await context.SaveChangesAsync();

                    var storeId = newStore.StoreId;

                    await context.People.Where(p => p.PersonId == request.PersonId && p.IsSeller == false).ExecuteUpdateAsync(p => p.SetProperty(p => p.IsSeller, true));

                    await transaction.CommitAsync();

                    return storeId;

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

        public static async Task<DTO_SellerGetStoreSammary> FirstStore(int personId)
        {

            using var context = Settings.CreateContext();


            var store = await context.Stores.Where(s => s.PersonId == personId).Select(s => new DTO_SellerGetStoreSammary
            {
                StoreId = s.StoreId,
                StoreName = s.StoreName,
                PersonId = s.PersonId,
                Description = s.StoreDescription,
                OrdersCount = context.OrderItems
    .Where(o => o.Product.StoreId == s.StoreId)
    .Select(o => o.OrderId)
    .Distinct()
    .Count(),
                ProductsCount = s.Products.Count,
                Revenue = context.OrderItems
    .Where(i => i.Product.StoreId == s.StoreId && i.Order.OrderStatusId == 5)
    .Sum(i => i.UnitPrice * i.Quantity),
            }).FirstOrDefaultAsync();

            return store;

        }


        public static async Task<DTO_SellerGetStoreSammary> LoadStoreByStoreID(int storeId)
        {

            using var context = Settings.CreateContext();


            var store = await context.Stores.Where(s => s.StoreId == storeId).Select(s => new DTO_SellerGetStoreSammary
            {
                StoreId = s.StoreId,
                PersonId = s.PersonId,
                StoreName = s.StoreName,
                Description = s.StoreDescription,
                OrdersCount = context.OrderItems
    .Where(o => o.Product.StoreId == s.StoreId)
    .Select(o => o.OrderId)
    .Distinct()
    .Count(),
                ProductsCount = s.Products.Count,
                Revenue = context.OrderItems
    .Where(i => i.Product.StoreId == s.StoreId && i.Order.OrderStatusId == 5)
    .Sum(i => i.UnitPrice * i.Quantity),
            }).FirstOrDefaultAsync();

            return store;

        }

        public static async Task<List<DTO_SellerStoreNameAndId>> LoadStoresNameAndId(int personId)
        {

            using var context = Settings.CreateContext();


            var stores = await context.Stores.Where(s => s.PersonId == personId).Select(s => new DTO_SellerStoreNameAndId
            {
                Id = s.StoreId,
                StoreName = s.StoreName
            }).ToListAsync();

            return stores;

        }


        public static async Task<int> CreateProduct(DTO_SellerCreateNewProduct newProduct)
        {
                using var context = Settings.CreateContext();

                using var transaction = await context.Database.BeginTransactionAsync();
                try
                {
                    var _newProduct = new Entities.Product
                    {
                        Name = newProduct.ProductName,
                        Description = newProduct.Description,
                        StoreId = newProduct.StoreId,
                        Price = newProduct.Price,
                        StockQuantity = newProduct.StockQuantity,
                        CategoryId = newProduct.CategoryId
                    };

                    await context.Products.AddAsync(_newProduct);

                    await context.SaveChangesAsync();

                    int prodcutId = _newProduct.ProductId;

                    var _productImages = new List<Entities.ProductImage>();

                    foreach (string path in newProduct.ProductImagePaths)
                    {
                        _productImages.Add(
                            new Entities.ProductImage
                            {
                                ImagePath = path,
                                ProductId = prodcutId
                            });
                    }

                    await context.ProductImages.AddRangeAsync(_productImages);

                    await context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    return prodcutId;

                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
         }

        public static async Task<bool> EditProduct(DTO_SellerEditProduct product)
        {
            using var context = Settings.CreateContext();

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {

                await context.Products.Where(p => p.ProductId == product.ProductId).ExecuteUpdateAsync(p => p.SetProperty(p => p.Name, product.ProductName)
                .SetProperty(p => p.Description, product.Description)
                .SetProperty(p => p.Price, product.Price)
                .SetProperty(p => p.StockQuantity, product.StockQuantity)
                .SetProperty(p => p.CategoryId, product.CategoryId));

               
                await context.ProductImages.Where(p=> p.ProductId == product.ProductId).ExecuteDeleteAsync();

                    var _productImages = new List<Entities.ProductImage>();

                    foreach (string path in product.ProductImagePaths)
                    {
                        _productImages.Add(
                            new Entities.ProductImage
                            {
                                ImagePath = path,
                                ProductId = product.ProductId
                            });
                    }

                    await context.ProductImages.AddRangeAsync(_productImages);

                    await context.SaveChangesAsync();
               

                

                await transaction.CommitAsync();

                return true;

            }
            catch
            {
                await transaction.RollbackAsync();
                return false;
            }
        }


        public static async Task<DTO_MyOrdersResponse> StoreOrders(DTO_SellerStoreOrdersRequest request)
        {

            using var context = Settings.CreateContext();

            DTO_MyOrdersResponse response = new DTO_MyOrdersResponse();


            var query = context.Orders
                .OrderBy(o => o.OrderStatusId)
        .AsNoTracking();

            if (request.StoreId.HasValue)
                query = query.Where(r => r.Items.Where(i => i.Product.StoreId == request.StoreId).Any());


            var orders = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize).Select(o => new DTO_OrderSummary
                    {
                        OrderNumber = o.OrderId,
                     
                        TotalAmount = request.StoreId.HasValue?
                        o.Items
                        .Where(i => i.Product.StoreId == request.StoreId)
                        .Sum(i => i.Quantity * i.UnitPrice)
                        :
                        o.Items.Sum(i => i.Quantity * i.UnitPrice),

                        ItemsCount = request.StoreId.HasValue
    ? o.Items.Count(i => i.Product.StoreId == request.StoreId.Value)
    : o.Items.Count(),

                        OrderStatusId = o.OrderStatusId,
                        OrderDate = o.OrderDate
                    }).ToListAsync();


            response.Orders = orders;
            response.AvalibleOrdersCount = await query.CountAsync();
            response.LastPageNumber = (int)Math.Ceiling((double)response.AvalibleOrdersCount / request.PageSize);
            response.HasNextPage = await query
            .Skip(request.PageNumber * request.PageSize)
            .AnyAsync();

            return response;


        }


        public static async Task<DTO_OrderDetails> GetOrdersDetailsForStore(DTO_SellerGetOrderDetailsForStore request)
        {
            using var context = Settings.CreateContext();

            var order = await context.Orders.Where(o => o.OrderId == request.OrderId && o.Items.Any(i => i.Product.StoreId == request.StoreId))
            .Select(o => new DTO_OrderDetails
            {
                Items = o.Items
                    .Where(i => i.Product.StoreId == request.StoreId)
                    .Select(i => new DTO_OrderItem
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
                TotalAmount = o.Items
    .Where(i => i.Product.StoreId == request.StoreId)
    .Sum(i => i.Quantity * i.UnitPrice)
            }

            ).FirstOrDefaultAsync();



            return order;

        }


        public static async Task<DTO_ReviewViewResponse> GetReviewsByStoreId(DTO_ReviewViewRequest request)
        {
            using var context = Settings.CreateContext();

            DTO_ReviewViewResponse response = new DTO_ReviewViewResponse();

            var query = context.Reviews
    .Where(r => r.Product.StoreId == request.StoreId)
    .AsNoTracking();

            var reviews = await query
                .OrderByDescending(r => r.ReviewId)
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .Select(r => new DTO_ReviewView
                    {

                        ReviewDate = r.Date,
                        ReviewId = r.ReviewId,
                        ReviewRate = r.Rate,
                        ReviewText = r.ReviewText,
                        ProductId = r.ProductId,
                        ProductName = r.Product.Name,
                        ProductImagePath = r.Product.ProductImages.Select(x => x.ImagePath).FirstOrDefault()


                    }).ToListAsync();



            response.Reviews = reviews;
            response.AvalibleReviewsCount = await query.CountAsync();
            response.LastPageNumber = (int)Math.Ceiling((double)response.AvalibleReviewsCount / request.PageSize);
            response.HasNextPage = await query
            .Skip(request.PageNumber * request.PageSize)
            .AnyAsync();

            return response;

        }




    }
}
