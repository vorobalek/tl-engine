using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;

namespace TL.Api.Web.Api.System
{
    public class BadController : _SystemApiController
    {
        public override string Command => "system.Bad";

        public override string Description => "Используйте для выполнения тестового неудачного запроса.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров")]
        public IActionResult Get() => this.JsonResponse(
               ok: false,
               error_code: StatusCodes.Status400BadRequest,
               description: "Bad Request. This is sample bad request like a demo version.");
    }
}
