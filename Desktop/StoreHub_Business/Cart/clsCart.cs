using StoreHub_Data.Classes.Cart;
using StoreHub_DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Cart
{
    public class clsCart
    {

        public static async Task<DTO_Cart> GetCartByPersonID(int Id)
        {
            try
            {
                var cart = await CartData.GetCartByPersonID(Id);

                return cart;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<bool> IncreaseItemQuantity(int itemId, int personId)
        {
            try
            {
                bool cart = await CartData.IncreaseItemQuantity(itemId,personId);

                return cart;
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
                await CartData.DecreaseItemQuantity(itemId, personId);
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
                bool res = await CartData.AddItemToCart(productId, personId);

                return res;
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
                int quantity = await CartData.GetItemQuantityByProduct(productId, personId);

                return quantity;
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
                int count = await CartData.GetCartItemsCount(personId);

                return count;
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
                await CartData.DeleteItem(itemId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
