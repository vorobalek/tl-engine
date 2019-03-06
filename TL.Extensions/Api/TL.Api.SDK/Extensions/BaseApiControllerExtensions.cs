using Microsoft.AspNetCore.Mvc;
using System;
using TL.Api.SDK.Controllers;
using TL.Api.SDK.Formats;

namespace TL.Api.SDK.Extensions
{
    public static class BaseApiControllerExtensions
    {
        public static IActionResult JsonResponse(this BaseApiController controller, bool ok, object result = null, int? error_code = null, string description = null)
        {
            var ret = new JsonApiResponseFormat(ok, result, error_code, description);
            if (controller.HttpContext.Items.ContainsKey("RequestStartedOn"))
            {
                if (controller.HttpContext.Items["RequestStartedOn"] is DateTime stamp)
                {
                    ret.RequestTime = DateTime.Now - stamp;
                }
            }

            if (!ok)
            {
                return controller.StatusCode(error_code ?? 400, ret);
            }
            return controller.Ok(ret);
        }
    }
}
