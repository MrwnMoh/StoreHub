using Microsoft.AspNetCore.WebUtilities;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Admin;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Admin
{
    public class clsAdmin
    {




        public static async Task<DTO_AdminDashboardResponse> Dashboard()
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_AdminDashboardResponse>("Admin/Dashboard");

            return response;
        }
        public static async Task NotActive(int id)
        {
           await clsDefultes.Client.PutAsync($"Admin/NotActive/{id}",null);
        }

        private static string BuildUsersQuery(DTO_AdminGetUsersRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString(),
                ["Filter"] = request.Filter.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Admin/Users",
                query
            );

            return url;
        }
        private static string BuildStoresQuery(DTO_GetStoresSummarysRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Admin/Stores",
                query
            );

            return url;
        }



        public static async Task<DTO_AdminGetUsersResponse> Users(DTO_AdminGetUsersRequest request)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_AdminGetUsersResponse>(BuildUsersQuery(request));

            return response;
        }
        public static async Task<DTO_GetStoresSummarys> Stores(DTO_GetStoresSummarysRequest request)
        {
            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_GetStoresSummarys>(BuildStoresQuery(request));

            return response;
        }


        public static async Task<int> CreateNewPerson(DTO_PersonCreate newData)
        {
            var response = await clsDefultes.Client.PostAsJsonAsync("Admin/CreatePerson", newData);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<int>();
            }
            return -1;
        }


    }
}
