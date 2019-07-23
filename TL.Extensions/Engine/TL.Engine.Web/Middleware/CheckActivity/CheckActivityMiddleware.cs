using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.Middleware
{
    public class CheckActivityMiddleware
    {
        public const string CheckActivityEnableVariable = "CheckActivityEnable";

        public const string UpdateActivityEnableVariable = "UpdateActivityEnable";

        private readonly RequestDelegate _next;

        public CheckActivityMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserManager userManager, IStringVariableManager stringVariableManager, ILogger<CheckActivityMiddleware> logger, IStartupService startupService)
        {
            if (startupService.IsOk)
            {
                try
                {
                    if (context.User.Identity.IsAuthenticated)
                    {
                        if (stringVariableManager.Get(CheckActivityEnableVariable) is StringVariable checkActivity && checkActivity.Value == true.ToString())
                        {
                            var claimUserId = context.User.Claims.FirstOrDefault(c => c.Type == nameof(User.Id));
                            var claimUserWebTicket = context.User.Claims.FirstOrDefault(c => c.Type == nameof(User.WebTicket))?.Value ?? "";

                            if (claimUserId != null)
                            {
                                if (Guid.TryParse(claimUserId.Value, out Guid userId))
                                {
                                    if (userManager.GetByKey(userId) is User user && !user.IsClosed)
                                    {
                                        if (stringVariableManager.Get(UpdateActivityEnableVariable) is StringVariable updateActivity && updateActivity.Value == true.ToString())
                                        {
                                            if (DateTime.Now - user.LastActivity < TimeSpan.FromDays(1)
                                                || DateTime.Now - user.LastLogon < TimeSpan.FromDays(1))
                                            {
                                                user.LastActivity = DateTime.Now.ToUniversalTime();
                                                userManager.Update(user);
                                            }
                                        }

                                        if (Guid.TryParse(claimUserWebTicket, out Guid userWebTicket) && userWebTicket == user.WebTicket)
                                        {
                                            await _next(context);
                                            return;
                                        }
                                    }
                                }
                            }

                            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.TLogCritical($"Не удалось выполнить {GetType().GetFullName()}\r\n{ex}");
                }
            }
            await _next(context);
        }
    }
}
