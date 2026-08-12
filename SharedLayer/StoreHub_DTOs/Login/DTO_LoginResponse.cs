using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_DTOs.Login
{
    public class DTO_LoginResponse
    {

        public DTO_Person person {  get; set; }

        public string AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiresAt { get; set; }
        public DateTime? RefreshTokenRevokedAt { get; set; }




    }
}
