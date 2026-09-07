using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Store
{
    public class DTO_SellerStoreOrdersRequest
    {

        public int? StoreId { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }



    }
}
