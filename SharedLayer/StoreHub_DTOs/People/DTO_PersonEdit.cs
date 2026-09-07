using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.People
{
    public class DTO_PersonEdit
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string? ImagePath { get; set; }
        public string Email { get; set; }

        public int PersonID { get; set; }
        public int CountryID { get; set; }

        public string Address {  get; set; }

        public DateOnly BirthDate { get; set; }

        public bool IsMale { get; set; }


    }
}
