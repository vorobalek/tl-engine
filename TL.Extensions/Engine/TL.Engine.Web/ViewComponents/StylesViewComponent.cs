using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.ViewComponents;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class StylesViewComponent : ActivatorViewComponent
    {
        public StylesViewComponent(IActivatorService activator) : base(activator)
        {
        }

        public IViewComponentResult Invoke()
        {
            return this.View(new StylesViewModelFactory().Create(Activator));
        }
    }
}