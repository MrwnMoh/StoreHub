using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Products
{
    public class DTO_ProductsGetAllResponse
    {

        public List<DTO_ProductsSummary>? Products { get; set; }

        public bool HasNextPage { get; set; }

        public int LastPageNumber { get; set; }

        public int AvalibleProductsCount { get; set; }



    }
}
