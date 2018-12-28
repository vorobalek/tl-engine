using Microsoft.AspNetCore.Http;
using System;
using TL.Api.Web.Formats;

namespace TL.Api.Web.Extensions
{
    public static class HttpContextExtensions
    {
        public static JsonApiResponseFormat GetJson(this HttpContext httpContext, bool ok, object result = null, int? error_code = null, string description = null)
        {
            var ret = new JsonApiResponseFormat(ok, result, error_code, description);
            if (httpContext.Items.ContainsKey("RequestStartedOn"))
            {
                if (httpContext.Items["RequestStartedOn"] is DateTime stamp)
                {
                    ret.RequestTime = DateTime.Now - stamp;
                }
            }
            return ret;
        }
    }
}
