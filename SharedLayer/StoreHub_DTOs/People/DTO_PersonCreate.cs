using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.People
{
    public class DTO_PersonCreate
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Password { get; set; }

        public int CountryId { get; set; }

        public string Email {  get; set; }
        public string Address {  get; set; }


        public string Phone { get; set; }


        public bool IsMale { get; set; }

        public string? ImagePath { get; set; }


        public DateOnly BirthDate { get; set; }







    }
}
