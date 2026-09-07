using StoreHub_Data.Classes.Admin;
using StoreHub_DTOs.Admin;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Admin
{
    public class clsAdmin
    {

        public static async Task<DTO_AdminDashboardResponse> Dashboard()
        {
            return await clsAdminData.Dashboard();
        }
        public static async Task<DTO_AdminGetUsersResponse> Users(DTO_AdminGetUsersRequest request)
        {
            return await clsAdminData.Users(request);
        }
        public static async Task<bool> IsAdmin(int personId)
        {
            return await clsAdminData.IsAdmin(personId);
        }
        public static async Task<int> CreatePerson(DTO_PersonCreate req)
        {
            return await clsAdminData.CreatePerson(req);
        }
        public static async Task NotActive(int personId)
        {
          await clsAdminData.NotActive(personId);
        }
        public static async Task<DTO_GetStoresSummarys> StoresSummary(DTO_GetStoresSummarysRequest request)
        {
            return await clsAdminData.StoresSummary(request);
        }



    }
}
