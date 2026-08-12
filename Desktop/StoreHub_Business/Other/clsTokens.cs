using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StoreHub_Data.Entities;
using StoreHub_DTOs.Login;
using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Other
{
    public class clsTokens
    {
        private readonly IConfiguration _configuration;

        public clsTokens(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<DTO_LoginResponse> GenrateLoginResponse(DTO_Person person)
        {
            DTO_LoginResponse response = new DTO_LoginResponse();
            response.person = person;
            response.RefreshToken = GenerateRefreshToken();
            response.AccessToken = await  GenerateAccessToken(person);
            response.RefreshTokenRevokedAt = null;
            response.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(15);

            return response;
        }

        private async Task<string> GenerateAccessToken(DTO_Person person)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,person.PersonId.ToString()),
                    new Claim(ClaimTypes.Email,person.Email)
                };

            if (person.IsAdmin)
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));

            if (person.IsSeller)
                claims.Add(new Claim(ClaimTypes.Role, "Seller"));




            var secretKey = _configuration["Jwt:Key"];


            if (string.IsNullOrWhiteSpace(secretKey))
            {
                throw new Exception("JWT secret key is not configured.");
            }


            if (int.TryParse(_configuration["Jwt:Time"], out int jwtTime) && jwtTime <= 0)
            {
                throw new Exception("JWT expiration time is not configured correctly.");
            }

            var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(secretKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(jwtTime),
            signingCredentials: creds);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
           


            return accessToken;
        }



        private string GenerateRefreshToken()
        {
            var bytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }



    }
}
