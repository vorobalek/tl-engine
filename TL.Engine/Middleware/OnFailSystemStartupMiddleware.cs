using Microsoft.AspNetCore.Http;
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
            if (!context.Request.Path.StartsWithSegments("/Styles") && !context.Request.Path.StartsWithSegments("/Scripts"))
            {
                if (!startupService.IsOk)
                {
                    context.Request.Path = startupService.RedirectUrl;
                }
            }
            return _next(context);
        }
    }
}
