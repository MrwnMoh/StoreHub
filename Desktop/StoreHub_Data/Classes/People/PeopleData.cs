using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_Data.Data;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StoreHub_Data.Classes.People
{
    public class PeopleData
    {


        public static async Task<DTO_Person> FindPersonByEmail(string email)
        {

            try
            {
                using var context = Settings.CreateContext();

                var result = await context.People.AsNoTracking().Select(p => new {p.PersonId, p.FirstName, p.LastName,p.PasswordHash, p.Email,p.Country.CountryName, p.Address, p.IsMale, p.IsActive, p.ImagePath, p.IsSeller,p.IsAdmin, p.RegisterAt, p.BirthDate, p.Phone }
                ).FirstOrDefaultAsync(p => p.Email == email);

                if (result == null)
                    return null;

                DTO_Person person = new DTO_Person();
                person.PersonId = result.PersonId;
                person.Address = result.Address;
                person.FirstName = result.FirstName;
                person.LastName = result.LastName;
                person.Email = email;
                person.ImagePath = result.ImagePath;
                person.RegisterAt = result.RegisterAt;
                person.BirthDate = result.BirthDate;
                person.Phone = result.Phone;
                person.IsActive = result.IsActive;
                person.IsAdmin = result.IsAdmin;
                person.IsSeller = result.IsSeller;
                person.IsMale = result.IsMale;
                person.CountryName = result.CountryName;
                person.PasswordHash = result.PasswordHash;

                return person;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            

        }

        public static async Task CreateOrUpdateRefreshToken(DTO_RefreshToken refreshToken, int PersonId)
        { 
        
            using var context = Settings.CreateContext();

            string hash = BCrypt.Net.BCrypt.HashPassword(
    refreshToken.RefreshToken
);

            var exists = await context.RefreshTokens
    .AnyAsync(r => r.PersonId == PersonId);

            if (exists)
            {
                await context.RefreshTokens.Where(r=> r.PersonId == PersonId)
                    .ExecuteUpdateAsync(r=> r.SetProperty(r => r.RefreshTokenExpiresAt,refreshToken.RefreshTokenExpiresAt)
                    .SetProperty(r => r.RefreshTokenRevokedAt,refreshToken.RefreshTokenRevokedAt)
                    .SetProperty(r => r.RefreshTokenHash, hash));
            }
            else
            {
                var newToken = new Entities.RefreshToken();
                newToken.RefreshTokenHash = hash;
                newToken.RefreshTokenExpiresAt = refreshToken.RefreshTokenExpiresAt;
                newToken.RefreshTokenRevokedAt = refreshToken.RefreshTokenRevokedAt;
                newToken.PersonId = PersonId;
                await context.RefreshTokens.AddAsync(newToken);

                await context.SaveChangesAsync();
            }

        }

        public static async Task<bool> IsEmailRegisteredByAnotherPerson(string email,int personId)
        {
            using var context = Settings.CreateContext();


            return await context.People.AnyAsync(p=> p.Email == email && p.PersonId !=  personId);

        }

        public static async Task<bool> IsEmailRegisteredByAnyOne(string email)
        {
            using var context = Settings.CreateContext();


            return await context.People.AnyAsync(p => p.Email == email);

        }


        public static async Task<bool> IsPhoneRegisteredByAnotherPerson(string Phone, int personId)
        {
            using var context = Settings.CreateContext();


            return await context.People.AnyAsync(p => p.Phone == Phone && p.PersonId != personId);

        }
        public static async Task<bool> IsPhoneRegisteredByAnyOne(string Phone)
        {
            using var context = Settings.CreateContext();

            return await context.People.AnyAsync(p => p.Phone == Phone);

        }

        public static async Task<bool> EditPersonInfo(DTO_PersonEdit newData)
        {
            using var context = Settings.CreateContext();

            if (context.People.Any(p =>(p.Phone == newData.PhoneNumber ||p.Email == newData.Email) && p.PersonId != newData.PersonID))
            {
                return false;
            }

            int rows = await context.People.Where(p => p.PersonId == newData.PersonID).ExecuteUpdateAsync(p => p.SetProperty(p => p.Address, newData.Address)
            .SetProperty(p => p.FirstName, newData.FirstName).SetProperty(p => p.LastName, newData.LastName).SetProperty(p=> p.BirthDate,newData.BirthDate)
            .SetProperty(p=> p.IsMale,newData.IsMale).SetProperty(p => p.CountryId,newData.CountryID).SetProperty(p=> p.Email,newData.Email)
            .SetProperty(p=> p.Phone,newData.PhoneNumber).SetProperty(p=> p.ImagePath,string.IsNullOrWhiteSpace( newData.ImagePath)? null : newData.ImagePath));

            return rows == 1;
        }

        public static async Task<bool> Logout(int personId)
        {
            using var context = Settings.CreateContext();

            int rows = await context.RefreshTokens.Where(p => p.PersonId == personId)
                .ExecuteUpdateAsync(p => p.SetProperty(p => p.RefreshTokenRevokedAt, DateTime.Now));
            
            return rows == 1;
        }


    }
}
