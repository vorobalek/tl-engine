using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Attributes.Http.SDK;

namespace TL.Api.Web.Attributes.Http
{
    public class ApiHttpDeleteAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpDeleteAttribute()
            : base(new string[] { "DELETE" }, "")
        {
        }

        public ApiHttpDeleteAttribute(string template)
            : base(new string[] { "DELETE" }, template)
        {
        }
    }
}
