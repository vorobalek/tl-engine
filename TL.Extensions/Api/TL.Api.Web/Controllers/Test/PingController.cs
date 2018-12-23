using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Api.Web.Attributes.Http;

namespace TL.Api.Web.Controllers.Test
{
    public class PingController : __TestBaseApiController__
    {
        public override string Command => "test.Ping";

        public override string Description => "Используйте для проверки скорости отклика сервера.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(TimeSpan))]
        public IActionResult Get()
        {
            if (HttpContext.Items.ContainsKey("RequestStartedOn"))
            {
                if (HttpContext.Items["RequestStartedOn"] is DateTime stamp)
                {
                    return Ok(GetJson(
                        ok: true,
                        result: new { time = (DateTime.Now - stamp) }));
                }
                else
                {
                    return Json(GetJson(
                        ok: false,
                        error_code: StatusCodes.Status503ServiceUnavailable,
                        description: "Service Unavailable. The request timestamp is uncorrect."));
                }
            }
            else
            {
                return Json(GetJson(
                    ok: false,
                    error_code: StatusCodes.Status503ServiceUnavailable,
                    description: "Service Unavailable. The request timestamp is undefined."));
            }
        }
    }
}
