using Microsoft.AspNetCore.WebUtilities;
using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System.Net.Http.Json;

namespace Shop_Desktop_Business
{
    public class clsPerson
    {






        public static async Task<DTO_LoginResponse> Login(DTO_LoginRequest request)
        {
            var result = await clsDefultes.Client.PostAsJsonAsync("Auth/Login", request);

            if(!result.IsSuccessStatusCode)
            {
                var errorMessage = await result.Content.ReadAsStringAsync();

                throw new Exception(errorMessage);
            }

            var response = await result.Content.ReadFromJsonAsync<DTO_LoginResponse>();
            
            if(response == null)
            {
                throw new Exception("Error while reading the data");
            }

            return response;

        }

        public static async Task<bool> EditPersonData(DTO_PersonEdit newData)
        {
            try
            {
                var response= await clsDefultes.Client.PutAsJsonAsync("People/EditPersonInfo", newData);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return true;
            }
        }


        public static async Task<bool> IsEmailRegisteredByAnotherPerson(string email,int personId)
        {
            try
            {

                var query = new Dictionary<string, string?>
                {
                    ["email"] = email,
                    ["personId"] = personId.ToString()
                };

                string url = QueryHelpers.AddQueryString(
                    "People/IsEmailRegisteredByAnotherPerson",
                    query
                );

                bool result = await clsDefultes.Client
                    .GetFromJsonAsync<bool>(url);

                return result;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public static async Task<bool> IsEmailRegisteredByAnyOne(string email)
        {
            try
            {

                var query = new Dictionary<string, string?>
                {
                    ["email"] = email
                };

                string url = QueryHelpers.AddQueryString(
                    "People/IsEmailRegisteredByAnyOne",
                    query
                );

                bool result = await clsDefultes.Client
                    .GetFromJsonAsync<bool>(url);

                return result;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public static async Task<bool> Logout()
        {
            var result = await clsDefultes.Client.PostAsJsonAsync("Auth/Logout", clsDefultes.LogendUser.person.PersonId);

            if (!result.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }


        public static async Task<bool> IsPhoneRegisteredByAnotherPerson(string Phone, int personId)
        {

                var query = new Dictionary<string, string?>
                {
                    ["Phone"] = Phone,
                    ["personId"] = personId.ToString()

                };

                string url = QueryHelpers.AddQueryString(
                    "People/IsPhoneRegisteredByAnotherPerson",
                    query
                );

                bool result = await clsDefultes.Client
                    .GetFromJsonAsync<bool>(url);

                return result;
        }

        public static async Task<bool> IsPhoneRegisteredByAnyOne(string Phone)
        {

            var query = new Dictionary<string, string?>
            {
                ["Phone"] = Phone
            };

            string url = QueryHelpers.AddQueryString(
                "People/IsPhoneRegisteredByAnyOne",
                query
            );

            bool result = await clsDefultes.Client
                .GetFromJsonAsync<bool>(url);

            return result;
        }



    }


}
