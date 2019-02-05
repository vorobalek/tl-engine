using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Extensions
{
    public static class UserExtensions
    {
        public static Task AuthenticateAsync(this User user, IStorage storage, HttpContext httpContext)
        {
            return Task.Run(async () =>
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                    new Claim(nameof(User.Id), user.Id.ToString())
                };

                var roles = storage.GetRepository<IUserRoleRepository>().GetByUser(user);
                foreach (var userRole in roles)
                {
                    var role = storage.GetRepository<IRoleRepository>().GetById(userRole.RoleId);
                    claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role.Name));
                }

                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            });
        }

        public static IEnumerable<Guid> GetFollowers(this User user, IStorage storage)
        {
            var followers = storage.GetRepository<ISubscriptionRepository>().Followers(user);
            return followers;
        }

        public static IEnumerable<Guid> GetSubscriptions(this User user, IStorage storage)
        {
            var subscriptions = storage.GetRepository<ISubscriptionRepository>().Subscriptions(user);
            return subscriptions;
        }
    }
}
