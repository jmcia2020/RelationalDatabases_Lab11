using AsyncInn.Models.API;
using AsyncInn.Models.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Services
{
    public interface IUserService
    {
        Task<UserDto> Register(RegisterData data, ModelStateDictionary modelState);
        Task<UserDto> Authenticate(string username, string password);
    }
}
