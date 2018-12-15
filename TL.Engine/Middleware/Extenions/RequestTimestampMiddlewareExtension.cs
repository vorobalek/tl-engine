using Microsoft.AspNetCore.Builder;

namespace TL.Engine.Middleware.Extenions
{
    public static class RequestTimestampMiddlewareExtension
    {
        public static IApplicationBuilder UseRequestTimestamp(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimestampMiddleware>();
        }
    }
}
