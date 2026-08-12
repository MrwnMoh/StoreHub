using Shop_Desktop_Business.Other;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System.Net.Http.Json;

namespace Shop_Desktop_Business
{
    public class Person
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



    }
}
