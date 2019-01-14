using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Api.Web.Api.System
{
    [Route("api/system.[controller]")]
    public abstract class _SystemApiController : BaseApiController
    {
        public _SystemApiController(IStorage storage) : base(storage)
        {
        }

        public override string Area => "System";
    }
}
