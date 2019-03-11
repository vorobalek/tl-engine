using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Integrations.SDK.Controllers
{
    [Area("Integrations")]
    [Authorize(Roles = "sa")]
    public abstract class BaseIntegrationsController : BaseController
    {
        public BaseIntegrationsController(IStorage storage) : base(storage)
        {
        }
    }
}
