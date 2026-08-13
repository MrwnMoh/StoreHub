using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Cart;
using StoreHub_DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Classes.Cart
{
    public class CartData
    {

        public static async Task<DTO_Cart> GetCartByPersonID(int PersonId)
        {

            try
            {
                using var context = Settings.CreateContext();


                var Cart = await context.Carts.AsNoTracking()
                    .Where(c => c.PersonId == PersonId)
            .Select(p => new DTO_Cart
            {
                CartID = p.CartId,
                PersonID = p.PersonId,
                CartItems = p.Items.Select(i => new DTO_CartItem { ItemID = i.CartItemId, ProductID = i.ProductId, Price = i.Product.Price, ProductName = i.Product.Name, ImagePath = i.Product.ProductImages.Select(img => img.ImagePath).FirstOrDefault(), Quantity = i.Quantity }).ToList(),
                TotalPrice = p.Items.Sum(i => i.Product.Price * i.Quantity)
            }).FirstOrDefaultAsync();



                return Cart;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static async Task<bool> IncreaseItemQuantity(int itemId,int personId)
        {

        try
        {
            using var context = Settings.CreateContext();


            return await context.CartItems.Where(i => i.CartItemId == itemId &&
            i.Cart.PersonId == personId &&
            i.Quantity+1 <=  i.Product.StockQuantity)
                    .ExecuteUpdateAsync(u  => u.SetProperty(p => p.Quantity , p => p.Quantity +1)) ==1;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        }

        public static async Task<bool> AddItemToCart(int productId, int personId)
        {

            try
            {
                using var context = Settings.CreateContext();

                var cart = await context.Carts.Where(c => c.PersonId == personId).FirstOrDefaultAsync();

                if (cart == null)
                    throw new Exception("No cart founds");


                var item = await context.CartItems
                    .FirstOrDefaultAsync(i =>
                        i.CartId == cart.CartId &&
                        i.ProductId == productId);

                if (item == null)
                {
                    context.CartItems.Add(new CartItem
                    {
                        CartId = cart.CartId,
                        ProductId = productId
                    });
                }
                else
                {
                    item.Quantity++;
                }





                return await context.SaveChangesAsync() == 1;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public static async Task DecreaseItemQuantity(int itemId, int personId)
        {

            try
            {
                using var context = Settings.CreateContext();


                await context.CartItems.Where(i => i.CartItemId == itemId &&
                i.Cart.PersonId == personId &&
                i.Quantity -1 >= 1)
                .ExecuteUpdateAsync(u => u.SetProperty(p => p.Quantity, p => p.Quantity - 1));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static async Task DeleteItem(int itemId)
        {

            try
            {
                using var context = Settings.CreateContext();


                await context.CartItems.Where(i => i.CartItemId == itemId )
                .ExecuteDeleteAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public static async Task<int> GetItemQuantityByProduct(int productId, int personId)
        {

            try
            {
                using var context = Settings.CreateContext();

                int Quantity = await context.CartItems.AsNoTracking().Where(c => c.Cart.PersonId == personId && c.ProductId  == productId).Select(q => q.Quantity).FirstOrDefaultAsync();

                return Quantity;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public static async Task<int> GetCartItemsCount(int personId)
        {

            try
            {
                using var context = Settings.CreateContext();

                int count = await context.Carts.AsNoTracking().Where(c => c.PersonId == personId).Select(c => c.Items.Count()).FirstOrDefaultAsync();

                return count;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
