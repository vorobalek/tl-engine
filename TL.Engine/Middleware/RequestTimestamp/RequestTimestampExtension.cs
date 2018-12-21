using Microsoft.AspNetCore.Builder;

namespace TL.Engine.Middleware
{
    public static class RequestTimestampExtension
    {
        public static IApplicationBuilder UseRequestTimestamp(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimestampMiddleware>();
        }
    }
}
