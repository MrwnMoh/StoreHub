using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace StoreHub_Api.Classes
{
    public class clsUtilty
    {

        public static async Task<bool> CheckOwnerPolicy(ClaimsPrincipal User,IAuthorizationService authorizationService, int id)
        {
            var authResult = await authorizationService.AuthorizeAsync(User, id, "UserOwnerAdminPolicy");

            return authResult.Succeeded;
        }


    }
}
