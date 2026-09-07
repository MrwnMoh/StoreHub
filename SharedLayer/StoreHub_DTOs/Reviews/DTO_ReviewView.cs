using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_ReviewView
    {


        public int ReviewId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ReviewText { get; set; }

        public DateTime ReviewDate { get; set; }

        public decimal ReviewRate { get; set; }

        public string? ProductImagePath { get; set; }

       


    }
}
