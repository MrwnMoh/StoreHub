using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.IdentityModel.Tokens;
using StoreHub_Business;
using StoreHub_Business.Other;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace StoreHub_Api.Controllers
{

    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly clsTokens _tokens;

        public AuthController(clsTokens tokens)
        {
            _tokens = tokens;
        }


        [HttpPost("Login")]
        public async Task<ActionResult<DTO_LoginResponse>> Login([FromBody] DTO_LoginRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Credentials are required");
            }

            DTO_Person person = await People.FindPersonByEmail(request.Email);

            if(person  == null)
                return Unauthorized("Invalid Credentials.");

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, person.PasswordHash);

            if(!isValidPassword)
                return Unauthorized("Invalid Credentials.");

            DTO_LoginResponse response = await _tokens.GenrateLoginResponse(person);

            return response;




        }


      

    }
}
