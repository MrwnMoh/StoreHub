using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Reviews
{
    public class DTO_ReviewViewResponse
    {


        public List<DTO_ReviewView> Reviews { get; set; }

        public int AvalibleReviewsCount { get; set; }

        public bool HasNextPage { get; set; }

        public int LastPageNumber { get; set; }


    }
}
