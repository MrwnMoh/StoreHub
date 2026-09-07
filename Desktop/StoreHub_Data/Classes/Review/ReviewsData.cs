using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StoreHub_Data.Classes.Review
{
    public class ReviewsData
    {
        public static async Task<DTO_ReviewViewResponse> GetReviewsByPersonId(DTO_ReviewViewRequest request)
        {
            using var context = Settings.CreateContext();

                DTO_ReviewViewResponse response = new DTO_ReviewViewResponse();

            var query = context.Reviews
    .Where(r => r.PersonId == request.PersonId)
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
