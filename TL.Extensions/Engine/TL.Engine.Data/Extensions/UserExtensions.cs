using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;

namespace TL.Engine.Data.Extensions
{
    public static class UserExtensions
    {
        public static async void Authenticate(this User user, IServiceProvider serviceProvider, HttpContext httpContext)
        {
            var storage = serviceProvider.GetService<IStorage>();
            var roleManager = serviceProvider.GetService<IRoleManager>();
            var userManager = serviceProvider.GetService<IUserManager>();

            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                    new Claim(nameof(User.Id), user.Id.ToString()),
                    new Claim(nameof(User.WebTicket), user.WebTicket.ToString()),
                };

            var roles = storage.GetRepository<IUserRoleRepository>().GetByUser(user);
            foreach (var userRole in roles)
            {
                var role = roleManager.GetByKey(userRole.RoleId);
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role.Name));
            }

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            user.LastLogon = DateTime.Now.ToUniversalTime();
            userManager.Update(user);

            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
