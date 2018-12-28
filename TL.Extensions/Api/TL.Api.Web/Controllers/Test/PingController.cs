using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Extensions;

namespace TL.Api.Web.Controllers.Test
{
    public class PingController : __TestBaseApiController__
    {
        public override string Command => "test.Ping";

        public override string Description => "Используйте для проверки скорости отклика сервера.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(TimeSpan))]
        public IActionResult Get()
        {
            return Ok(HttpContext.GetJson(true));
        }
    }
}
