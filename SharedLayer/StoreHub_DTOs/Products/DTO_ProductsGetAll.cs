using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Products
{
    public class DTO_ProductsGetAll
    {

        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int CategoryId { get; set; }
        public int? StoreId { get; set; }

        public string? SearchFilter { get; set; }

        public EProductSort SortBy { get; set; }

        public enum EProductSort
        {
            Featured = 0,
            PriceLowToHigh = 1,
            PriceHighToLow = 2,
            AverageReview = 3,

            LastProdcuts = 4
        }


    }
}
