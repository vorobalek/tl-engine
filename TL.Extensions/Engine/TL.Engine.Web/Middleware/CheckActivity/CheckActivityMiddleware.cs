using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;

namespace TL.Engine.Web.Middleware
{
    public class CheckActivityMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckActivityMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserManager userManager)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                var claimUserId = context.User.Claims.FirstOrDefault(c => c.Type == nameof(User.Id));
                if (claimUserId != null)
                {
                    if (Guid.TryParse(claimUserId.Value, out Guid userId))
                    {
                        if (userManager.Get(userId) is User user && !user.IsClosed)
                        {
                            if (DateTime.Now - user.LastActivity < TimeSpan.FromDays(1)
                                || DateTime.Now - user.LastLogon < TimeSpan.FromDays(1))
                            {
                                user.LastActivity = DateTime.Now.ToUniversalTime();
                                userManager.Update(user);
                                await _next(context);
                                return;
                            }
                        }
                    }
                }
                await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            await _next(context);
        }
    }
}
