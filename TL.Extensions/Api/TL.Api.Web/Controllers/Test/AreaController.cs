using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TL.Api.Web.Attributes.Http;
using TL.Api.Web.Objects;
using TL.Api.Web.Services;

namespace TL.Api.Web.Controllers.Test
{
    public class AreaController : __TestBaseApiController__
    {
        public override string Command => "test.Area";

        public override string Description => "Используйте для получения методов некоторой области API";

        [ApiHttpGet(UsageDescription = "Без параметров будут возвращены все области", ReturnableType = typeof(IList<ApiAreaModel>))]
        public IActionResult Get()
        {
            new ApiDocumentationService().CheckDocumentation();

            var dict = new Dictionary<string, IList<ApiMethodModel>>();
            var result = new List<ApiAreaModel>();

            foreach (var method in ApiDocumentation.Methods)
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

            return Ok(GetJson(true, result));
        }

        [ApiHttpGet("{name}", UsageDescription = "Укажите имя области методов API как часть маршрута", ReturnableType = typeof(ApiAreaModel), UsageSample = "/Test")]
        public IActionResult Get(string name)
        {
            new ApiDocumentationService().CheckDocumentation();
            var result = new ApiAreaModel()
            {
                Name = name.ToLowerInvariant(),
                Methods = ApiDocumentation.Methods.Where(method => method.Area.ToLowerInvariant() == name.ToLowerInvariant()).ToList()
            };
                
            return Ok(GetJson(true, result));
        }
    }
}
