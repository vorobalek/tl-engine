using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Controllers.SDK;

namespace TL.Api.Web.Controllers.System
{
    [Route("api/system.[controller]")]
    public abstract class __SystemBaseApiController__ : __BaseApiController__
    {
        public override string Area => "System";
    }
}
