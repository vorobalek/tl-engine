using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Controllers;

namespace TL.Api.Web.Api.System
{
    [Route("api/system.[controller]")]
    public abstract class _SystemApiController : BaseApiController
    {
        public override string Area => "System";
    }
}
