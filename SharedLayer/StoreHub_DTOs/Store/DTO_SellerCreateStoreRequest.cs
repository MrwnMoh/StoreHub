using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Store
{
    public class DTO_SellerCreateStoreRequest
    {

        public int PersonId { get; set; }

        public string StoreName { get; set; }

        public string? Description { get; set; }


    }
}
