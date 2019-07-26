using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.ViewComponents
{
    public abstract class ActivatorViewComponent : BaseViewComponent, IActivatorViewComponent
    {
        protected IActivatorService Activator { get; }

        public ActivatorViewComponent(IActivatorService activator)
        {
            Activator = activator;
        }
    }
}
