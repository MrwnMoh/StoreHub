using StoreHub_Data.Classes.People;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;

namespace StoreHub_Business
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









    }
}
