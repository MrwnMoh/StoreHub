using Microsoft.EntityFrameworkCore;
using StoreHub_Data.Classes.Other;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Admin;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.People;
using StoreHub_DTOs.Products;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static StoreHub_DTOs.Products.DTO_ProductsGetAll;

namespace StoreHub_Data.Classes.Admin
{
    public class clsAdminData
    {

        public static async Task<DTO_AdminDashboardResponse> Dashboard()
        {

            using var context = Settings.CreateContext();



            var response = new DTO_AdminDashboardResponse
            {
                StoresCount = await context.Stores.CountAsync(),
                OrdersCount = await context.Orders.CountAsync(),
                ProductsCount = await context.Products.CountAsync(p => !p.IsDeleted),
                UserCount = await context.People.CountAsync()
            };
            return response;


        }


        public static async Task<bool> IsAdmin(int personId)
        {

            using var context = Settings.CreateContext();


            bool res = await context.People.Where(p=>p.PersonId == personId).Select(p=>p.IsAdmin).FirstOrDefaultAsync();


            return res;
        }
        public static async Task<int> CreatePerson(DTO_PersonCreate req)
        {

            using var context = Settings.CreateContext();


            var newPerson = new Entities.Person
            {
                Email = req.Email,
                Address = req.Address,
                Phone = req.Phone,
                BirthDate = req.BirthDate,
                FirstName = req.FirstName,
                LastName = req.LastName,
                CountryId = req.CountryId,
                IsMale = req.IsMale,
                ImagePath = req.ImagePath,
                IsActive = true,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(req.Password)
            };

            await context.People.AddAsync(newPerson);

            await context.SaveChangesAsync();

            return newPerson.PersonId;
        }

        public static async Task<DTO_AdminGetUsersResponse> Users(DTO_AdminGetUsersRequest request)
        {

            try
            {
                using var context = Settings.CreateContext();

                var query = context.People.AsNoTracking().AsQueryable();

                if(request.Filter != DTO_AdminGetUsersRequest.eFilter.Mix)
                {
                    switch (request.Filter)
                    {
                        case DTO_AdminGetUsersRequest.eFilter.IsSeller:
                            query = query.Where(p => p.IsSeller == true);
                            break;

                        case DTO_AdminGetUsersRequest.eFilter.IsAdmin:
                            query = query.Where(p => p.IsAdmin == true);
                            break;

                        case DTO_AdminGetUsersRequest.eFilter.Male:
                            query = query.Where(p => p.IsMale == true);
                            break;
                        case DTO_AdminGetUsersRequest.eFilter.Female:
                            query = query.Where(p => p.IsMale == false);
                            break;
                        case DTO_AdminGetUsersRequest.eFilter.NotActive:
                            query = query.Where(p => p.IsActive == false);
                            break;
                        case DTO_AdminGetUsersRequest.eFilter.Active:
                            query = query.Where(p => p.IsActive == true);
                            break;
                    }

                }


                int _Count = await query.CountAsync();


                int _LastPage = (int)Math.Ceiling((double)_Count / request.PageSize);

                bool hasNextPage = await query
                .Skip(request.PageNumber * request.PageSize)
                .AnyAsync();


                var users = await query
                    .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(p => new DTO_PersonSummary
            {
               Email = p.Email,
               FirstName = p.FirstName,
                LastName = p.LastName,
                Address = p.Address,
                BirthDate = p.BirthDate,
                CountryId = p.CountryId,
               IsActive = p.IsActive,
               IsAdmin = p.IsAdmin,
               IsMale = p.IsMale,
               IsSeller = p.IsSeller,
               PersonId = p.PersonId,
               Phone = p.Phone,
               UserImagePath = p.ImagePath
            })
            .ToListAsync();

                DTO_AdminGetUsersResponse response = new DTO_AdminGetUsersResponse();
                response.Users = users;
                response.HasNextPage = hasNextPage;
                response.LastPageNumber = _LastPage;
                response.AvalibleUsersCount = _Count;

                return response;

            }
            catch (Exception ex)
            {
                throw;
            }



        }

        public static async Task NotActive(int personId)
        {

            using var context = Settings.CreateContext();

            await context.People.Where(p=> p.PersonId == personId).ExecuteUpdateAsync(p => p.SetProperty(p => p.IsActive, false));
        }

        public static async Task<DTO_GetStoresSummarys> StoresSummary(DTO_GetStoresSummarysRequest request)
        {

            using var context = Settings.CreateContext();

            var query = context.Stores.AsQueryable();


            int _Count = await query.CountAsync();


            int _LastPage = (int)Math.Ceiling((double)_Count / request.PageSize);

            bool hasNextPage = await query
            .Skip(request.PageNumber * request.PageSize)
            .AnyAsync();

            query = query.Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize);

            var stores = await query
            .Select(s =>  new DTO_StoreDetails
            {
                Id = s.StoreId,
                StoreName = s.StoreName,
                StoreOwnerName = s.Person.FirstName+ " " + s.Person.LastName,
                OrdersCount = s.Products.SelectMany(p=>p.OrderItems).Select(oi => oi.OrderId).Distinct().Count(),
                ProductsCount = s.Products.Count,
                Revenu = s.Products
    .SelectMany(p => p.OrderItems)
    .Sum(i => i.Quantity * i.UnitPrice)

            }).ToListAsync();


            DTO_GetStoresSummarys response = new DTO_GetStoresSummarys();
            response.Stores = stores;
            response.LastPageNumber = _LastPage;
            response.HasNextPage = hasNextPage;
            response.AvalibleOrdersCount = _Count;

            return response;

        }


    }
}
