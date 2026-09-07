using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Order
{
    public class DTO_OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string? ImagePath { get; set; }


    }
}
