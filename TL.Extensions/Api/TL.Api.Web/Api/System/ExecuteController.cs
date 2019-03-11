using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class ExecuteController : _SystemApiController
    {
        public ExecuteController(IStorage storage) : base(storage)
        {
        }

        public override string Command => "system.Execute";

        public override string Description => $"Используйте для выполнения метода API";

        [ApiHttpGet("{method}", UsageDescription = "Этот метод требует указать имя метода как часть запроса", UsageSample = "/test", ReturnableType = typeof(object))]
        public IActionResult Get(string method)
        {
            var m = method.Split(":");
            var type = m[0];
            var func = m[1];

            return this.JsonResponse(true, result: new { report = $"Execute HTTP GET whith method = {method}" });
        }
    }
}
