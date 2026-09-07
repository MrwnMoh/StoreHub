using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Order
{
    public class DTO_MyOrdersResponse
    {

        public List<DTO_OrderSummary> Orders { get; set; }

        public int AvalibleOrdersCount { get; set; }

        public bool HasNextPage { get; set; }

        public int LastPageNumber { get; set; }

    }
}
