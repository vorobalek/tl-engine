using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace $safeprojectname$.Api.$saferootprojectname$
{
    [Route("api/$lower_saferootprojectname$.[controller]")]
    public abstract class _$saferootprojectname$ApiController : BaseApiController
    {
        public _$saferootprojectname$ApiController(IStorage storage) : base(storage)
        {
        }

        public override string Area => "$saferootprojectname$";
    }
}