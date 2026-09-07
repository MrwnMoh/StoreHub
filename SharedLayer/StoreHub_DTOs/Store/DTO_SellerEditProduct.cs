using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Store
{
    public class DTO_SellerEditProduct
    {

        public string ProductName { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public int ProductId { get; set; }

        public List<string>? ProductImagePaths { get; set; }

    }
}
