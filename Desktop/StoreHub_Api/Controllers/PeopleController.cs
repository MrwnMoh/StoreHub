using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreHub_Api.Classes;
using StoreHub_Business.People;
using StoreHub_Data.Data;
using StoreHub_Data.Entities;
using StoreHub_DTOs;
using StoreHub_DTOs.People;
using System.Security.Claims;

namespace StoreHub_Api.Controllers
{

    
    [Authorize]

    [EnableRateLimiting("Cart")]


    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        private readonly IAuthorizationService _authorizationService;
        public PeopleController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        [HttpPut("EditPersonInfo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<bool>> EditPersonInfo(DTO_PersonEdit newData)
        {
            if(string.IsNullOrWhiteSpace(newData.Address) || string.IsNullOrWhiteSpace(newData.PhoneNumber) || string.IsNullOrWhiteSpace(newData.FirstName) ||
                string.IsNullOrWhiteSpace(newData.LastName) || newData.PersonID <=0 || newData.CountryID <= 0)
            {
                return BadRequest("Data not accepted");
            }


            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, newData.PersonID))
            {
                return Forbid();
            }


            try
            {
                bool res = await People.EditPersonInfo(newData);
                if (!res)
                    return NotFound();

                return Ok(true);
            }
            catch 
            {
                throw;
            }
        }


        [HttpGet("IsEmailRegisteredByAnotherPerson")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> IsEmailRegisteredByAnotherPerson([FromQuery] string email, [FromQuery] int personId)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest("Data not accepted");
            }

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }

            bool res = await People.IsEmailRegisteredByAnotherPerson(
                email,
                personId
            );

            return Ok(res);
        }
        [HttpGet("IsEmailRegisteredByAnyOne")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> IsEmailRegisteredByAnyOne([FromQuery] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest("Data not accepted");
            }

            int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }

            bool res = await People.IsEmailRegisteredByAnyOne(
                email
            );

            return Ok(res);
        }

        [HttpGet("IsPhoneRegisteredByAnotherPerson")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> IsPhoneRegisteredByAnotherPerson([FromQuery] string phone, [FromQuery] int personId)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return BadRequest("Data not accepted");
            }

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }

            bool res = await People.IsPhoneRegisteredByAnotherPerson(
                phone,
                personId
            );

            return Ok(res);
        }

        [HttpGet("IsPhoneRegisteredByAnyOne")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> IsPhoneRegisteredByAnyOne([FromQuery] string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return BadRequest("Data not accepted");
            }

            int personId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            if (!await clsUtilty.CheckOwnerPolicy(User, _authorizationService, personId))
            {
                return Forbid();
            }

            bool res = await People.IsPhoneRegisteredByAnyOne(
                phone
            );

            return Ok(res);
        }


    }
}
