using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace TL.Engine.Middleware
{
    public class RequestTimestampMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimestampMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Items.Add("RequestStartedOn", DateTime.Now);

            return _next(context);
        }
    }
}
