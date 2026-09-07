using StoreHub_DTOs.Order;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Admin
{
    public class DTO_GetStoresSummarys
    {

        public List<DTO_StoreDetails> Stores { get; set; }

        public int AvalibleOrdersCount { get; set; }

        public bool HasNextPage { get; set; }

        public int LastPageNumber { get; set; }

    }
}
