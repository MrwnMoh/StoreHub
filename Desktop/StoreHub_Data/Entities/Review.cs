using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Review
    {

        public int ReviewId { get; set; }
        public int PersonId { get; set; }
        public decimal Rate { get; set; }
        public int ProductId { get; set; }
        public string? ReviewText { get; set; }
        public DateTime Date { get; set; }

        public bool Edited { get; set; }

        public virtual Person Person { get; set; }
        public virtual Product Product { get; set; }




    }
}
