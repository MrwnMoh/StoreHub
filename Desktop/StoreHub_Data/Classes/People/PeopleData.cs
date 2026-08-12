using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Data;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreHub_Data.Classes.Other;
namespace StoreHub_Data.Classes.People
{
    public class PeopleData
    {


        public static async Task<DTO_Person> FindPersonByEmail(string email)
        {

            try
            {
                using var context = Settings.CreateContext();

                var result = await context.People.Select(p => new {p.PersonId, p.FirstName, p.LastName, p.Email, p.CountryId, p.Address, p.IsMale, p.IsActive, p.ImagePath, p.IsSeller, p.PasswordHash, p.IsAdmin, p.RegisterAt, p.BirthDate, p.Phone }
                ).FirstOrDefaultAsync(p => p.Email == email);

                if (result == null)
                    return null;

                DTO_Person person = new DTO_Person();
                person.PersonId = result.PersonId;
                person.Address = result.Address;
                person.FirstName = result.FirstName;
                person.LastName = result.LastName;
                person.Email = email;
                person.CountryId = result.CountryId;
                person.ImagePath = result.ImagePath;
                person.RegisterAt = result.RegisterAt;
                person.BirthDate = result.BirthDate;
                person.Phone = result.Phone;
                person.IsActive = result.IsActive;
                person.IsAdmin = result.IsAdmin;
                person.IsSeller = result.IsSeller;
                person.IsMale = result.IsMale;
                person.PasswordHash = result.PasswordHash;

                return person;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            

        }



        


    }
}
