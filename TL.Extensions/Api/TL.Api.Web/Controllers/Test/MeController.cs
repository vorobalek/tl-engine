using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using TL.Api.Web.Attributes.Http;

namespace TL.Api.Web.Controllers.Test
{
    public class MeController : __TestBaseApiController__
    {
        public override string Command => "test.Me";

        public override string Description => "Используйте для получения информации о сервере";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(AssemblyName))]
        public IActionResult Get() =>
            Ok(GetJson(true, Assembly.GetEntryAssembly().GetName()));
    }
}
