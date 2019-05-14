using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    [Area("Integrations")]
    [Authorize(Roles = "sa")]
    public abstract class __IntegrationsController__ : BaseController
    {
    }
}
