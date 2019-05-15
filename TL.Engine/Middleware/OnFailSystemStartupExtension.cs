using Microsoft.AspNetCore.Builder;

namespace TL.Engine.Middleware
{
    public static class OnFailSystemStartupExtension
    {
        public static IApplicationBuilder UseFailRedirection(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<OnFailSystemStartupMiddleware>();
        }
    }
}
