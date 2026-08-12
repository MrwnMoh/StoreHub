using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Cart
    {

        public int CartId { get; set; }

        public int PersonId { get; set; }


        public virtual Person Person { get; set; }

        public virtual List<CartItem> Items { get; set; }

    }
}
