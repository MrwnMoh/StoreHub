using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Data.Entities
{
    public class Person
    {

        public int PersonId { get; set; }

        public int CountryId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Phone { get; set; }

        public string? ImagePath { get; set; }

        public DateOnly BirthDate { get; set; }

        public DateOnly RegisterAt { get; set; }

        public bool IsMale { get; set; }

        public bool IsActive { get; set; }

        public bool IsSeller { get; set; }

        public bool IsAdmin { get; set; }

        public virtual Country Country { get; set; }

        public virtual List<Store> Stores { get; set; }

        public virtual RefreshToken? RefreshToken { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<Review> Reviews { get; set; }

    }
}
