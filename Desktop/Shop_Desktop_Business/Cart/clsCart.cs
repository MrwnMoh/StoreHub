using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Cart;
using StoreHub_DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Cart
{
    public class clsCart
    {



        public static async Task<DTO_Cart> LoadCartByPersonId(int personId)
        {
            try
            {


                var response = await clsDefultes.Client.GetAsync($"Cart/{personId}");

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var cart = await response.Content.ReadFromJsonAsync<DTO_Cart>();

                    if (cart != null)
                        return cart;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }


        public static async Task<bool> IncreaseQuantity(int itemId)
        {
            try
            {
                var res = await clsDefultes.Client.PatchAsync($"Cart/Items/{itemId}/Increase",null);

                bool result = await res.Content.ReadFromJsonAsync<bool>();

                return result;
            }
            catch
            {
                throw;
            }
        }

        public static async Task DecreaseItemQuantity(int itemId)
        {
            try
            {

                var response = await clsDefultes.Client.PatchAsync($"Cart/Items/{itemId}/Decrease",null);

                response.EnsureSuccessStatusCode();

            }
            catch
            {
                throw;
            }
        }

        public static async Task DeleteItem(int itemId)
        {
           var response = await clsDefultes.Client.DeleteAsync($"Cart/{itemId}");
        }

        public static async Task<bool> AddItemToCart(int ProductId)
        {
            try
            {
                var res = await clsDefultes.Client.PostAsync($"Cart/{ProductId}",null);

                bool result = await res.Content.ReadFromJsonAsync<bool>();

                return result;
            }
            catch
            {
                throw;
            }
        }

        public static async Task<int> GetItemQuantity(int ProductId)
        {
            try
            {
                var Quantity = await clsDefultes.Client.GetFromJsonAsync<int>($"Cart/Quantity/{ProductId}");

                return Quantity;
            }
            catch
            {
                throw;
            }
        }

        public static async Task<int> CartItemsCount(int personID)
        {
            try
            {
                var count = await clsDefultes.Client.GetFromJsonAsync<int>($"Cart/CartItemsCount/{personID}");

                return count;
            }
            catch
            {
                throw;
            }
        }



    }
}
