using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Order
    {

        public int OrderId { get; set; }

        public int PersonId { get; set; }

        public int OrderStatusId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; }


        public virtual Person Person { get; set; }

        public virtual OrderStatus OrderStatus { get; set; }

        public virtual List<OrderItem> Items { get; set; }



    }
}
