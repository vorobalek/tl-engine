using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Extensions;
using TL.Api.Web.Services;

namespace TL.Api.Web.Controllers.System
{
    public class HelpController : __SystemBaseApiController__
    {
        private readonly IApiDocumentationService apiDocumentationService;

        public HelpController()
        {
            this.apiDocumentationService = new ApiDocumentationService();
        }

        public override string Command => "system.Help";

        public override string Description => $"Используйте для получения автоматической API документации";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(ApiDocumentation))]
        public IActionResult Get() => Ok(HttpContext.GetJson(ok: true, result: apiDocumentationService.GetDocumentation(HttpContext.Request.Host)));
    }
}
