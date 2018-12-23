using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Services;

namespace TL.Api.Web.Controllers.Test
{
    public class HelpController : __TestBaseApiController__
    {
        private readonly IApiDocumentationService apiDocumentationService;

        public HelpController()
        {
            this.apiDocumentationService = new ApiDocumentationService();
        }

        public override string Command => "test.Help";

        public override string Description => $"Используйте для получения автоматической API документации";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(ApiDocumentation))]
        public IActionResult Get() => Ok(GetJson(ok: true, result: apiDocumentationService.GetDocumentation(HttpContext.Request.Host)));
    }
}
