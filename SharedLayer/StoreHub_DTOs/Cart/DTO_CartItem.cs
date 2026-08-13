using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Cart
{
    public class DTO_CartItem
    {


        public int ItemID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

    }
}
