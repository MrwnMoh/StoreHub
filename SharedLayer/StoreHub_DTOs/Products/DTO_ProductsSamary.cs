using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Products
{
    public class DTO_ProductsSamary
    {


        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string CategoryName { get; set; }

        public string? ImagePath { get; set; }

        public int? TotalRating { get; set; }

        public decimal? RatingAverage { get; set; }


        public int ProductID { get; set; }

    }
}
