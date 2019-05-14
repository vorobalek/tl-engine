using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.Api.SDK.Models;
using TL.Api.SDK.Services.ApiDocumentation;

namespace TL.Api.Web.Api.System
{
    public class HelpController : _SystemApiController
    {
        private IApiDocumentationService ApiDocumentationService { get; }

        public HelpController(IApiDocumentationService apiDocumentationService)
        {
            ApiDocumentationService = apiDocumentationService;
        }

        public override string Command => "system.Help";

        public override string Description => $"Используйте для получения автоматической API документации";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(ApiDocumentationModel))]
        public IActionResult Get()
        {
            var documentation = ApiDocumentationService.GetDocumentation(HttpContext.Request.Host);
            if (!User.Identity.IsAuthenticated)
            {
                var publicFunctions = documentation.Functions.Where(f => !f.IsPrivate).ToList();
                documentation.Functions = publicFunctions;
            }
            return this.JsonResponse(ok: true, result: documentation);
        }
    }
}
