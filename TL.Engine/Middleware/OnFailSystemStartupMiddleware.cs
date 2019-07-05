using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TL.Engine.SDK.Services;

namespace TL.Engine.Middleware
{
    public class OnFailSystemStartupMiddleware
    {
        private readonly RequestDelegate _next;

        public OnFailSystemStartupMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context, IStartupService startupService)
        {
            if (!context.Request.Path.StartsWithSegments("/Styles", StringComparison.InvariantCultureIgnoreCase) &&
                !context.Request.Path.StartsWithSegments("/Scripts", StringComparison.InvariantCultureIgnoreCase) &&
                !context.Request.Path.StartsWithSegments("/Runtime", StringComparison.InvariantCultureIgnoreCase))
            {
                if (!startupService.IsReady || !startupService.IsOk)
                {
                    context.Request.Path = startupService.RedirectUrl;
                }
            }
            return _next(context);
        }
    }
}
