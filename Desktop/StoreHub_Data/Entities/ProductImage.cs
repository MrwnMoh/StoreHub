using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class ProductImage
    {

        public int ProductImageId { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }


        public virtual Product Product { get; set; }

    }
}
