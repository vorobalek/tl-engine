using Microsoft.AspNetCore.Mvc;
using TL.Api.Web.Controllers.SDK;

namespace TL.Api.Web.Controllers.Test
{
    [Route("api/test.[controller]")]
    public abstract class __TestBaseApiController__ : __BaseApiController__
    {
        public override string Area => "Test";
    }
}
