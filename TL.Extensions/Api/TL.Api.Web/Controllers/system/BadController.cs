using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Extensions;

namespace TL.Api.Web.Controllers.System
{
    public class BadController : __SystemBaseApiController__
    {
        public override string Command => "system.Bad";

        public override string Description => "Используйте для выполнения тестового неудачного запроса.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров")]
        public IActionResult Get() => BadRequest(HttpContext.GetJson(
               ok: false,
               error_code: StatusCodes.Status400BadRequest,
               description: "Bad Request. This is sample bad request like a demo version."
           ));
    }
}
