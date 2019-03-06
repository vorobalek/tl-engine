using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;

namespace TL.Api.SDK.Attributes.Http
{
    public abstract class ApiHttpMethodAttribute : HttpMethodAttribute
    {
        public ApiHttpMethodAttribute(IEnumerable<string> httpMethods) : base(httpMethods)
        {
        }

        public ApiHttpMethodAttribute(IEnumerable<string> httpMethods, string template) : base(httpMethods, template)
        {
        }

        public string UsageDescription { get; set;  }

        public string UsageSample { get; set; }

        public Type ReturnableType { get; set; }
    }
}
