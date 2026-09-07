using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_ReviewViewRequest
    {


        public int PersonId { get; set; }

        public int? StoreId { get; set; }

        public int PageSize { get; set; }
        
        public int PageNumber { get; set; }

    }
}
