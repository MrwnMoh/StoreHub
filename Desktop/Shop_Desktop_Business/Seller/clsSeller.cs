using Microsoft.AspNetCore.WebUtilities;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Seller
{
    public class clsSeller
    {


        public static async Task<int> CreateStore(DTO_SellerCreateStoreRequest request)
        {
            var response = await clsDefultes.Client.PostAsJsonAsync("Seller/CreateStore", request);
            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<int>();
            }


            return 0;
        }

        public static async Task<int> CreateProduct(DTO_SellerCreateNewProduct request)
        {
            var response = await clsDefultes.Client.PostAsJsonAsync("Seller/CreateProduct", request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<int>();
            }


            return 0;
        }

        public static async Task<bool> EditProduct(DTO_SellerEditProduct product)
        {
            var req = await clsDefultes.Client.PutAsJsonAsync($"Seller/Product", product);

            if (req.IsSuccessStatusCode)
            {
                var response = await req.Content.ReadFromJsonAsync<bool>();
                return response;
            }
            return false;

        }



        public static async Task<DTO_SellerGetStoreSammary> FirstStore(int PersonId)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_SellerGetStoreSammary>($"Seller/FirstStore/{PersonId}");

         
            return response;
        }

        public static async Task<DTO_SellerGetStoreSammary> LoadStoreById(int storeId)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_SellerGetStoreSammary>($"Seller/StoreById/{storeId}");

         
            return response;
        }


        public static async Task<List<DTO_SellerStoreNameAndId>> LoadStoresNameAndId(int PersonId)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<List<DTO_SellerStoreNameAndId>>($"Seller/Stores/{PersonId}");

            return response;
        }


        private static string BuildStoreOrdersQuery(DTO_SellerStoreOrdersRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString()
            };

            if (request.StoreId.HasValue)
                query["StoreId"] = request.StoreId.ToString();

            string url = QueryHelpers.AddQueryString(
                "Seller/Orders",
                query
            );

            return url;
        }


        public static async Task<DTO_MyOrdersResponse> StoreOrders(DTO_SellerStoreOrdersRequest request)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_MyOrdersResponse>(BuildStoreOrdersQuery(request));
            return response;
        }







        private static string BuildGetOrderDetailsQuery(DTO_SellerGetOrderDetailsForStore request)
        {
            var query = new Dictionary<string, string?>
            {
                ["OrderId"] = request.OrderId.ToString(),
                ["StoreId"] = request.StoreId.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Seller/OrderDetails",
                query
            );

            return url;
        }


        public static async Task<DTO_OrderDetails> GetOrderDetailsForStore(DTO_SellerGetOrderDetailsForStore req)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_OrderDetails>(BuildGetOrderDetailsQuery(req));
            return response;
        }

        private static string BuildGetReviewsByStoreIdQuery(DTO_ReviewViewRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString(),
                ["PersonId"] = request.PersonId.ToString(),
                ["StoreId"] = request.StoreId.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Seller/Reviews",
                query
            );

            return url;
        }
        public static async Task<DTO_ReviewViewResponse> GetReviewsByStoreId(DTO_ReviewViewRequest request)
        {

            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_ReviewViewResponse>(BuildGetReviewsByStoreIdQuery(request));

            return response;
        }




    }
}
