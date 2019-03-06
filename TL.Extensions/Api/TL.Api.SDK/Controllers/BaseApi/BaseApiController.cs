using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Api.SDK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController : BaseController, IBaseApiController
    {
        public BaseApiController(IStorage storage) : base(storage)
        {
        }

        public abstract string Area { get; }

        public abstract string Command { get; }

        public abstract string Description { get; }
    }
}
