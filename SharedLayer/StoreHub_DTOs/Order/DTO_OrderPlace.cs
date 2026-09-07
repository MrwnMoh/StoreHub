using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Order
{
    public class DTO_OrderPlace
    {

        public int PersonID {  get; set; }

        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; }


    }
}
