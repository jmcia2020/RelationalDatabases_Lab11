using AsyncInn.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Services
{
    public class JwtTokenService
    {
        public async Task<string> GetToken(ApplicationUser user, TimeSpan expiresIn)
        {
            return "token!";
        }
    }
}
