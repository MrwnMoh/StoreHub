using Microsoft.AspNetCore.Mvc.ViewEngines;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business
{
    public class clsProducts
    {



        public static async Task<List<DTO_ProductsSamary>> LoadHomeProducts()
        {

            var products = await clsDefultes.Client.GetFromJsonAsync<List<DTO_ProductsSamary>>("Products/GetHomeProducts");

            return products;
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
                var response = await clsDefultes.Client.PostAsJsonAsync("Products/EditReview", request);
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                throw;
            }

        }


    }
}
