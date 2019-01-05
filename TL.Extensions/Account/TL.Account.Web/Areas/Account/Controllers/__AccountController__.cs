using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Controllers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Area("Account")]
    public abstract class __AccountController__ : __BaseController__
    {
        public __AccountController__(IStorage storage) : base(storage)
        {
        }

        protected async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username)
            };

            var roles = Storage.GetRepository<IUserRoleRepository>().GetByUser(user);
            foreach (var userRole in roles)
            {
                var role = Storage.GetRepository<IRoleRepository>().GetById(userRole.RoleId);
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role.Name));
            }

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
