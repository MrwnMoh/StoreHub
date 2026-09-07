using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Store
    {

        public int StoreId { get; set; }

        public int PersonId { get; set; }

        public string StoreName { get; set; }

        public string? StoreDescription { get; set; }

        public virtual Person Person {  get; set; }

        public virtual List<Product>? Products { get; set; }


    }
}
