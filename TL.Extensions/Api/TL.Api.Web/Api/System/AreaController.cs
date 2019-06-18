using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.Api.SDK.Models;
using TL.Api.SDK.Services.ApiDocumentation;

namespace TL.Api.Web.Api.System
{
    public class AreaController : _SystemApiController
    {
        private IApiDocumentationService ApiDocumentationService { get; }

        public AreaController(IApiDocumentationService apiDocumentationService)
        {
            ApiDocumentationService = apiDocumentationService;
        }

        public override string Command => "system.Area";

        public override string Description => "Используйте для получения методов некоторой области API";

        [ApiHttpGet(UsageDescription = "Без параметров будут возвращены все области", ReturnableType = typeof(IList<ApiAreaModel>))]
        public IActionResult Get()
        {
            var dict = new Dictionary<string, IList<ApiMethodModel>>();
            var result = new List<ApiAreaModel>();

            foreach (var method in ApiDocumentationService.Get().GetMethods())
            {
                var area = method.Area.ToLowerInvariant();
                if (method.Area.ToLowerInvariant() == area)
                {
                    if (dict.ContainsKey(area))
                    {
                        dict[area].Add(method);
                    }
                    else
                    {
                        dict.Add(area, new List<ApiMethodModel>(new[] { method }));
                    }
                }
            }

            foreach (var area in dict.Keys)
            {
                result.Add(new ApiAreaModel()
                {
                    Name = area,
                    Methods = dict[area]
                });
            }
            return this.JsonResponse(true, result);
        }

        [ApiHttpGet("{name}", UsageDescription = "Укажите имя области методов API как часть маршрута", ReturnableType = typeof(ApiAreaModel), UsageSample = "/Test")]
        public IActionResult Get(string name)
        {
            var result = new ApiAreaModel()
            {
                Name = name.ToLowerInvariant(),
                Methods = ApiDocumentationService
                    .Get()
                    .GetMethods()
                    .Where(method => method.Area.ToLowerInvariant() == name.ToLowerInvariant()).ToList()
            };
                
            return this.JsonResponse(true, result);
        }
    }
}
