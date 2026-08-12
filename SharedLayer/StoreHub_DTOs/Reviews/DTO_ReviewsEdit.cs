using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_ReviewsEdit
    {

        public int ReviewID { get; set; }
        public int PersonID { get; set; }

        public string ReviewText { get; set; }

        public decimal Rate { get; set; }



    }
}
