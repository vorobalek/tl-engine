using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Formats;

namespace TL.Api.Web.Controllers.SDK
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class __BaseApiController__ : Controller, __IBaseApiController__
    {
        public abstract string Area { get; }

        public abstract string Command { get; }

        public abstract string Description { get; }

        public virtual JsonApiResponseFormat GetJson(
            bool ok,
            object result = null,
            int? error_code = null,
            string description = null) => new JsonApiResponseFormat(ok, result, error_code, description);
    }
}
