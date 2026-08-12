using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace StoreHub_Api.Authorization
{
    public class UserOwnerAdminHandler : AuthorizationHandler<UserOwnerAdminRequirement,int>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserOwnerAdminRequirement requirement, int id)
        {

            //Admin
            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }


            //OwnerShip Check
            var caller = context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (caller != null && int.TryParse(caller, out int callerID) && callerID == id)
            {
                context.Succeed(requirement);
            }



            return Task.CompletedTask;

        }





    }
}
