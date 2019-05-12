using Microsoft.AspNetCore.Builder;

namespace TL.Engine.Web.Middleware
{
    public static class CheckActivityExtension
    {
        public static IApplicationBuilder UseCheckActivity(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckActivityMiddleware>();
        }
    }
}
