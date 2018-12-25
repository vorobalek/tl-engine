using Microsoft.AspNetCore.Builder;

namespace TL.Engine.Web.Middleware
{
    public static class RequestTimestampExtension
    {
        public static IApplicationBuilder UseRequestTimestamp(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimestampMiddleware>();
        }
    }
}
