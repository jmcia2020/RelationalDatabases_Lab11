﻿using AsyncInn.Models.API;
using AsyncInn.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterData data)
        {
            var user = await userService.Register(data, this.ModelState);
            if (!ModelState.IsValid)
            {
                // Replicates normal validation error response
                return BadRequest(new ValidationProblemDetails(ModelState));
            }

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login(LoginData data)
        {
            var user = await userService.Authenticate(data.Username, data.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            return user;
        }

        [Authorize]
        [HttpGet("Self")]
        public async Task<UserDto> Self()
        {
            return await userService.GetUser(this.User);
        }
    }
}
