using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Attributes.Http.SDK;

namespace TL.Api.Web.Attributes.Http
{
    public class ApiHttpPostAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpPostAttribute()
            : base(new string[] { "POST" }, "")
        {
        }

        public ApiHttpPostAttribute(string template)
            : base(new string[] { "POST" }, template)
        {
        }
    }
}
