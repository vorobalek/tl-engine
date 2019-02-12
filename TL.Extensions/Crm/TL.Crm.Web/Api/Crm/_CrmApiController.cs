using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Crm.Web.Api.Crm
{
    [Route("api/crm.[controller]")]
    public abstract class _CrmApiController : BaseApiController
    {
        public _CrmApiController(IStorage storage) : base(storage)
        {
        }

        public override string Area => "Crm";
    }
}