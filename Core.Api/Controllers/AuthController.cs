using Core.Services.Dto;
using Core.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        [HttpPost("logout")]
        [Authorize] // Sadece oturum açmış kullanıcılar için
        public async Task<IActionResult> Logout()
        {
            await _authService.Logout(); // Oturumu kapat

            return Ok(new { Message = "Logout successful." });
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<LoginResultDto> Login(string username, string password)
        {
            var obj = await _authService.LoginUser(username, password);
            return obj;
        }

        /// <summary>
        /// Register user with role
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">password</param>
        /// <param name="role">role</param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password, string role)
        {
            var result = await _authService.RegisterUser(username, password, role);

            if (result.Succeeded)
            {
                return Ok(new { Message = "User registered successfully." });
            }

            return BadRequest(new { Message = "Error during registration.", Errors = result.Errors });
        }
    }
}
