using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Attributes.Http.SDK;

namespace TL.Api.Web.Attributes.Http
{
    public class ApiHttpGetAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpGetAttribute()
            : base(new string[] { "GET" }, "")
        {
        }

        public ApiHttpGetAttribute(string template)
            : base(new string[] { "GET" }, template)
        {
        }
    }
}
