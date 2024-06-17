using Core.Services.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Interface
{
    public interface IAuthService
    {
        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        Task<bool> Logout();

        /// <summary>
        /// Register User with role
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<IdentityResult> RegisterUser(string username, string password, string role);

        /// <summary>
        /// login 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<LoginResultDto> LoginUser(string username, string password);
        string GenerateTokenString(string username, string password);
    }
}
