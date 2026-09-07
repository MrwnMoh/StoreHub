 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public int StoreId { get; set; }

        public bool IsDeleted { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public virtual Store Store { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Review>? Reviews { get; set; }

        public virtual List<OrderItem>? OrderItems { get; set; }

        public virtual List<ProductImage>? ProductImages { get; set; }

    }
}
