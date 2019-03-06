using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Resources;
using TL.Api.SDK.Attributes.Http;

namespace TL.Api.Web.Api.System
{
    public class ThnxController : _SystemApiController
    {
        public ThnxController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Thnx";

        public override string Description => "Используйте, чтобы узнать, кому мы обязаны своим крутым названием.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(string))]
        public IActionResult Get() => Content(GetThnxResources.Label);
    }
}
