using StoreHub_DTOs.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Products
{
    public class DTO_ProductsDetails
    {

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string CategoryName { get; set; }

        public string SellerName { get; set; }

        public string Description { get; set; }

        public List<string>? Images { get; set; }

        public List<DTO_Reviews>? Reviews { get; set; }

        public int ProductId { get; set; }

        public int StockQuantity { get; set; }

        public int StoreId { get; set; }



    }
}
