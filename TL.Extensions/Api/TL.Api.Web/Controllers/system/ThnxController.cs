using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Resources;

namespace TL.Api.Web.Controllers.System
{
    public class ThnxController : __SystemBaseApiController__
    {
        public override string Command => "system.Thnx";

        public override string Description => "Используйте, чтобы узнать, кому мы обязаны своим крутым названием.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Get() => Content(GetThnxResources.Label);
    }
}
