using AsyncInn.Models.API;
using AsyncInn.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace AsyncInn.Services
{
    public class IdentityUserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;

        public IdentityUserService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<UserDto> Authenticate(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);

            if (await userManager.CheckPasswordAsync(user, password))
            {
                return new UserDto
                {
                    Id = user.Id,
                    Username = user.UserName,
                };
            }

            if (user != null)
                await userManager.AccessFailedAsync(user);

            return null;
        }

        public async Task<UserDto> Register(RegisterData data, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser
            {
                UserName = data.Username,
                Email = data.Email,
                PhoneNumber = data.PhoneNumber,
                // PasswordHash = data.Password, // NO
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (result.Succeeded)
            {
                return new UserDto
                {
                    Id = user.Id,
                    Username = user.UserName,
                };
            }

            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? nameof(data.Password) :
                    error.Code.Contains("Email") ? nameof(data.Email) :
                    error.Code.Contains("UserName") ? nameof(data.Username) :
                    "";
                modelState.AddModelError(errorKey, error.Description);
            }

            return null;
        }

        //Task<ApplicationUser> IUserService.Register(RegisterData data, ModelStateDictionary modelState)
        //{
            //throw new System.NotImplementedException();
        //}
    }
}
