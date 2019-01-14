using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Attributes.Http;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Models;
using TL.Engine.SDK.Services.ApiDocumentation;

namespace TL.Api.Web.Api.System
{
    public class HelpController : _SystemApiController
    {
        private IApiDocumentationService ApiDocumentationService { get; }

        public HelpController(IStorage storage, IApiDocumentationService apiDocumentationService) : base(storage)
        {
            ApiDocumentationService = apiDocumentationService;
        }

        public override string Command => "system.Help";

        public override string Description => $"Используйте для получения автоматической API документации";

        [ApiHttpGet(UsageDescription = "Этот метод работает без параметров", ReturnableType = typeof(ApiDocumentationModel))]
        public IActionResult Get() => this.JsonResponse(ok: true, result: ApiDocumentationService.GetDocumentation(HttpContext.Request.Host));
    }
}
