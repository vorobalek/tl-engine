using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class HostController : _SystemApiController
    {
        public HostController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Host";

        public override string Description => $"Используйте для получения информации о хосте.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(HostString))]
        public IActionResult Get() => this.JsonResponse(true, HttpContext.Request.Host);
    }
}
