using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Extensions;

namespace TL.Api.Web.Controllers.System
{
    public class HostController : __SystemBaseApiController__
    {
        public override string Command => "system.Host";

        public override string Description => $"Используйте для получения информации о хосте.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(HostString))]
        public IActionResult Get() =>
            Ok(HttpContext.GetJson(true, HttpContext.Request.Host));
    }
}
