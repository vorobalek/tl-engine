using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;

namespace TL.Api.Web.Controllers.Test
{
    public class BadController : __TestBaseApiController__
    {
        public override string Command => "test.Bad";

        public override string Description => "Используйте для выполнения тестового неудачного запроса.";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров")]
        public IActionResult Get() => Json(GetJson(
               ok: false,
               error_code: StatusCodes.Status400BadRequest,
               description: "Bad Request. This is sample bad request like a demo version."
           ));
    }
}
