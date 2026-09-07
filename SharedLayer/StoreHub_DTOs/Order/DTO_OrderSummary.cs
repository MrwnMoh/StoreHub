using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Order
{
    public class DTO_OrderSummary
    {

        public int OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public int ItemsCount { get; set; }

        public int OrderStatusId { get; set; }

        public decimal TotalAmount { get; set; }

    }
}
