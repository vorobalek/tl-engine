using ExtCore.Data.Abstractions;
using TL.Integrations.SDK.Controllers;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    public abstract class __IntegrationsController__ : BaseIntegrationsController
    {
        public __IntegrationsController__(IStorage storage) : base(storage)
        {
        }
    }
}
