using TL.Engine.SDK.Services;

namespace TL.Api.SDK.Controllers
{
    public abstract class ActivatorApiController : BaseApiController, IActivatorApiController
    {
        protected IActivatorService Activator { get; }

        public ActivatorApiController(IActivatorService activator)
        {
            Activator = activator;
        }
    }
}
