using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.ViewComponents;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class ScriptsViewComponent : ActivatorViewComponent
    {
        public ScriptsViewComponent(IActivatorService activator) : base(activator)
        {
        }

        public IViewComponentResult Invoke()
        {
            return View(new ScriptsViewModelFactory().Create(Activator));
        }
    }
}