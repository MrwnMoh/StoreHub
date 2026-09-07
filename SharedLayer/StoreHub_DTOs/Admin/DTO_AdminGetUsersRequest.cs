using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Admin
{
    public class DTO_AdminGetUsersRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public enum eFilter
        { 
            Mix,
            IsAdmin,
            IsSeller,
            Male,
            Female,
            Active,
            NotActive
        }
        public eFilter Filter { get; set; }


    }
}
