using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Admin
{
    public class DTO_AdminDashboardResponse
    {


        public int UserCount {  get; set; }
        public int StoresCount {  get; set; }
        public int OrdersCount {  get; set; }
        public int ProductsCount {  get; set; }



    }
}
