using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Api.SDK.Controllers;

namespace TL.Integrations.Web.Api.Integrations
{
    [Route("api/integrations.[controller]")]
    public abstract class _IntegrationsApiController : BaseApiController
    {
        public _IntegrationsApiController(IStorage storage) : base(storage)
        {
        }

        public override string Area => "Integrations";
    }
}