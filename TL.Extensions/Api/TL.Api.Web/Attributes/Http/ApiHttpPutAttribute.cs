using System;
using System.Collections.Generic;
using System.Text;
using TL.Api.Web.Attributes.Http.SDK;

namespace TL.Api.Web.Attributes.Http
{
    public class ApiHttpPutAttribute : ApiHttpMethodAttribute
    {
        public ApiHttpPutAttribute()
            : base(new string[] { "PUT" }, "")
        {
        }

        public ApiHttpPutAttribute(string template)
            : base(new string[] { "PUT" }, template)
        {
        }
    }
}
