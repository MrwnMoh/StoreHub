using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Store
{
    public class DTO_SellerGetStoreSammary
    {

        public int StoreId { get; set; }    
        public int PersonId { get; set; }    
        public int ProductsCount { get; set; }    
        public int OrdersCount { get; set; }    
        public decimal Revenue { get; set; }    

        public string StoreName { get; set; }
        public string? Description { get; set; }



    }
}
