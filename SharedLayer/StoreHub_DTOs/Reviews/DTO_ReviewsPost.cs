using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_ReviewsPost
    {

        public decimal Rating { get; set; }

        public string ReviewText { get; set; }

        public int PersonID { get; set; }

        public int ProductID { get; set; }


    }
}
