using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.People
{
    public class DTO_PersonSummary
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }

        public DateOnly BirthDate { get; set; }
        public string? UserImagePath { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsMale { get; set; }

        public bool IsSeller { get; set; }

        public int PersonId { get; set; }
        public int CountryId { get; set; }




    }
}
