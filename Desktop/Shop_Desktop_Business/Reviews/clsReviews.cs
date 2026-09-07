using Microsoft.AspNetCore.WebUtilities;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Desktop_Business.Reviews
{
    public class clsReviews
    {

        private static string BuildGetReviewsByPersonIdQuery(DTO_ReviewViewRequest request)
        {
            var query = new Dictionary<string, string?>
            {
                ["PageNumber"] = request.PageNumber.ToString(),
                ["PageSize"] = request.PageSize.ToString(),
                ["PersonId"] = request.PersonId.ToString()

            };


            string url = QueryHelpers.AddQueryString(
                "Reviews/Reviews",
                query
            );

            return url;
        }

     


        public static async Task<DTO_ReviewViewResponse> GetReviewsByPersonId(DTO_ReviewViewRequest request)
        {

            var response = await clsDefultes.Client.GetFromJsonAsync<DTO_ReviewViewResponse>(BuildGetReviewsByPersonIdQuery(request));

            return response;
        }
       




    }
}
