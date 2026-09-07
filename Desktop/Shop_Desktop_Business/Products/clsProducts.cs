using Microsoft.AspNetCore.Mvc.ViewEngines;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using StoreHub_DTOs.Categories;

namespace Shop_Desktop_Business.Products
{
    public class clsProducts
    {

        private static string BuildGetAllProductQuery(DTO_ProductsGetAll request)
        {

            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString(),
                ["SortBy"] = request.SortBy.ToString(),
                ["CategoryId"] = request.CategoryId.ToString()

            };

            if (!string.IsNullOrWhiteSpace(request.SearchFilter))
            {
                query["SearchFilter"] = request.SearchFilter;
            }

            if (request.StoreId.HasValue)
            {
                query["StoreId"] = request.StoreId.ToString();
            }

            string url = QueryHelpers.AddQueryString(
                "Products/GetAllProducts",
                query
            );

            return url;
        }



        public static async Task<List<DTO_ProductsSummary>> LoadHomeProducts()
        {

            var products = await clsDefultes.Client.GetFromJsonAsync<List<DTO_ProductsSummary>>("Products/GetHomeProducts");

            return products;
        }


        public static async Task<List<DTO_Category>> GetProductCategories()
        {

            var Categories = await clsDefultes.Client.GetFromJsonAsync<List<DTO_Category>>("Products/GetProductCategories");

            return Categories;
        }


        public static async Task<DTO_ProductsGetAllResponse> LoadAllProducts(DTO_ProductsGetAll request)
        {
            //string url = BuildGetAllProductQuery(request);

            //var products = await clsDefultes.Client.GetFromJsonAsync<DTO_ProductsGetAllResponse>(url);

            //return products;

            string url = BuildGetAllProductQuery(request);

            var response = await clsDefultes.Client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                string error = await response.Content.ReadAsStringAsync();
                //clsUtrity($"{response.StatusCode}\n{error}");
                return null;
            }

            return await response.Content
                .ReadFromJsonAsync<DTO_ProductsGetAllResponse>();

        }


        public static async Task<DTO_ProductsSummary> GetProductSummaryById(int Id)
        {

            var product = await clsDefultes.Client.GetFromJsonAsync<DTO_ProductsSummary>($"Products/summary/{Id}");

            return product;
        }


        public static async Task<DTO_ProductsDetails> GetProductsDetailsById(int id)
        {
            try
            {
                var result = await clsDefultes.Client.GetFromJsonAsync<DTO_ProductsDetails>($"Products/{id}");
                return result;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
     
        }

        public static async Task<List<DTO_Reviews>> GetProductsReviewsById(int id)
        {
            try
            {
                var result = await clsDefultes.Client.GetFromJsonAsync<List<DTO_Reviews>>($"Products/Reviews{id}");
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static async Task<int> NumberOfTotalProducts()
        {
            return await clsDefultes.Client.GetFromJsonAsync<int>("Products/TotalProducts");
        }

        public static async Task PostAReview(DTO_ReviewsPost request)
        {
            try
            {
                var response = await clsDefultes.Client.PostAsJsonAsync("Products/PostReview", request);
                response.EnsureSuccessStatusCode();
            }
            catch 
            {
                throw ;
            }

        }

        public static async Task DeleteAReview(DTO_ReviewsDelete review)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Delete,"Products/Review")
                {
                    Content = JsonContent.Create(review)
                };

                var response = await clsDefultes.Client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                throw;
            }

        }

        public static async Task EditReview(DTO_ReviewsEdit request)
        {
            try
            {
                var response = await clsDefultes.Client.PatchAsJsonAsync("Products/EditReview", request);
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                throw;
            }

        }

        public static async Task<bool> DeleteProduct(int productId)
        {
            return await clsDefultes.Client.DeleteFromJsonAsync<bool>($"Products/Product/{productId}");
        }



    }
}
