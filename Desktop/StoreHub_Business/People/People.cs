using StoreHub_Data.Classes.People;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System.Net.Mail;

namespace StoreHub_Business.People
{
    public class People
    {







        public static async Task<DTO_Person> FindPersonByEmail(string email)
        {

            try
            {
                var person = await PeopleData.FindPersonByEmail(email);

                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static async Task CreateOrUpdateRefreshToken(DTO_RefreshToken token,int PersonId)
        {
            await PeopleData.CreateOrUpdateRefreshToken(token, PersonId); 
        }

        public static async Task<bool> EditPersonInfo(DTO_PersonEdit newData)
        {

            try
            {
                if(!MailAddress.TryCreate(newData.Email, out _))
                {
                    return false;
                }

                bool res = await PeopleData.EditPersonInfo(newData);

                return res;
            }
            catch
            {
                throw;
            }

        }

        public static async Task<bool> IsEmailRegisteredByAnotherPerson(string email,int personId)
        {

            try
            {
                bool res = await PeopleData.IsEmailRegisteredByAnotherPerson(email,personId);

                return res;
            }
            catch
            {
                throw;
            }

        }
        public static async Task<bool> IsEmailRegisteredByAnyOne(string email)
        {

            try
            {
                bool res = await PeopleData.IsEmailRegisteredByAnyOne(email);

                return res;
            }
            catch
            {
                throw;
            }

        }

        public static async Task<bool> IsPhoneRegisteredByAnotherPerson(string email, int personId)
        {
                bool res = await PeopleData.IsPhoneRegisteredByAnotherPerson(email, personId);
                return res;
        }
        public static async Task<bool> IsPhoneRegisteredByAnyOne(string email)
        {
                bool res = await PeopleData.IsPhoneRegisteredByAnyOne(email);
                return res;
        }


        public static async Task<bool> Logout(int id)
        {
                bool res = await PeopleData.Logout(id);
                return res;
        }

    }
}
