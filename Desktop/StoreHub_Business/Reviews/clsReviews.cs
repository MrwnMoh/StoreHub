using StoreHub_Data.Classes.Review;
using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Reviews
{
    public class clsReviews
    {


        public static async Task<DTO_ReviewViewResponse> GetReviewsByPersonId(DTO_ReviewViewRequest request)
        {
            return await ReviewsData.GetReviewsByPersonId(request);
        }



    }
}
