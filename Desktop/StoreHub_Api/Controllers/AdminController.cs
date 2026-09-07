using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using StoreHub_Api.Classes;
using StoreHub_Business.Admin;
using StoreHub_Business.People;
using StoreHub_Business.Seller;
using StoreHub_Data.Classes.Other;
using StoreHub_DTOs.Admin;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.People;
using StoreHub_DTOs.Store;
using System.Security.Claims;

namespace StoreHub_Api.Controllers
{


    [Authorize]


    [EnableRateLimiting("Admin")]
    [Route("api/Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {


        private readonly IAuthorizationService _authorizationService;
        public AdminController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }


        [HttpGet("Dashboard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_AdminDashboardResponse>> GetStoreOrders()
        {

            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId) || !await IsAdmin(personId))
                {
                    return Forbid();
                }

                var response = await clsAdmin.Dashboard();


                if (response != null)
                {
                    return Ok(response);
                }
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("Users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_AdminGetUsersResponse>> Users([FromQuery]DTO_AdminGetUsersRequest request)
        {

            if (request.PageNumber <= 0 || request.PageSize <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId) || !await IsAdmin(personId))
                {
                    return Forbid();
                }

                var response = await clsAdmin.Users(request);

                return Ok(response);
            

            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpPost("CreatePerson")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<int>> CreatePerson(DTO_PersonCreate newData)
        {
            if (string.IsNullOrWhiteSpace(newData.Address) || string.IsNullOrWhiteSpace(newData.Phone) || string.IsNullOrWhiteSpace(newData.FirstName) ||
                string.IsNullOrWhiteSpace(newData.LastName) || string.IsNullOrWhiteSpace(newData.Password) || newData.CountryId <= 0)
            {
                return BadRequest("Data not accepted");
            }

            int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }


            try
            {
                int res = await clsAdmin.CreatePerson(newData);
                return Ok(res);
            }
            catch
            {
                throw;
            }
        }

        [HttpPut("NotActive/{personId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<int>> NotActive(int personId)
        {
            if (personId <= 0)
            {
                return BadRequest("Data not accepted");
            }


            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }


            try
            {
               await clsAdmin.NotActive(personId);
                return Ok();
            }
            catch
            {
                throw;
            }
        }


        [HttpGet("Stores")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DTO_GetStoresSummarys>> Stores([FromQuery] DTO_GetStoresSummarysRequest request)
        {

            if (request.PageNumber <= 0 || request.PageSize <= 0)
            {
                return BadRequest("Data not accepted");
            }


            try
            {
                int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);


                if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId) || !await IsAdmin(personId))
                {
                    return Forbid();
                }

                var response = await clsAdmin.StoresSummary(request);

                return Ok(response);


            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }


        async Task<bool> IsAdmin(int personId)
        {
            return await clsAdmin.IsAdmin(personId);
        }

    }
}
