using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Order
{
    public class DTO_OrderDetails
    {


        public List<DTO_OrderItem> Items { get; set; }

        public string ShippingAddress { get; set; }

        public int OrderID { get; set; }

        public int OrderStatusID { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
