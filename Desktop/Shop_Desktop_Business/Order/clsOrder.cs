using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Order
{
    public class clsOrder
    {


        public static async Task<int> PlaceOrder(DTO_OrderPlace order)
        {
            try
            {
                var response = await clsDefultes.Client.PostAsJsonAsync("Order/PlaceOrder", order);
                if(response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<int>();

                return -1;
            }
            catch
            {
                throw;
            }
        }

        private static string BuildViewMyOrdersQuery(DTO_OrderViewMyRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString(),
                ["PersonId"] = request.PersonId.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Order/MyOrders",
                query
            );

            return url;
        }


        public static async Task<DTO_MyOrdersResponse> ViewMyOrders(DTO_OrderViewMyRequest request )
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_MyOrdersResponse>(BuildViewMyOrdersQuery(request));
            return response;
        }




        public static async Task<DTO_OrderDetails> GetOrderDetails(int orderId)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_OrderDetails>($"Order/OrderDetails/{orderId}");
            return response;
        }


        public static async Task<bool> CancelOrder(int orderId)
        {
            var req = await clsDefultes.Client.PutAsync($"Order/Cancel/{orderId}",null);

            if(req.IsSuccessStatusCode)
            {
                var response = await req.Content.ReadFromJsonAsync<bool>();

                return response;
            }

            return false;

        }

        public static async Task<bool> ChangeOrderStatus(DTO_OrderChangeStatus request)
        {
            var response = await clsDefultes.Client
                .PutAsJsonAsync("Order/OrderStatus", request);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<bool>();

            return false;

        }





    }
}
