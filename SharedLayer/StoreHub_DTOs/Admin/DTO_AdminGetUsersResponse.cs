using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Admin
{
    public class DTO_AdminGetUsersResponse
    {


        public List<DTO_PersonSummary> Users { get; set; }

        public int AvalibleUsersCount { get; set; }

        public bool HasNextPage { get; set; }

        public int LastPageNumber { get; set; }



    }
}
