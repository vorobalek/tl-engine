using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Extensions;

namespace TL.Api.Web.Controllers.System
{
    public class MeController : __SystemBaseApiController__
    {
        public override string Command => "system.Me";

        public override string Description => "Используйте для получения информации о сервере";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(AssemblyName))]
        public IActionResult Get() =>
            Ok(HttpContext.GetJson(true, Assembly.GetEntryAssembly().GetName()));
    }
}
