using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Cart
{
    public class DTO_Cart
    {

        public int CartID { get; set; }

        public int PersonID { get; set; }

        public decimal TotalPrice { get; set; }

        public List<DTO_CartItem>? CartItems { get; set; }



    }
}
