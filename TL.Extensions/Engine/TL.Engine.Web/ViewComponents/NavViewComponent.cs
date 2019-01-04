using Microsoft.AspNetCore.Mvc;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class NavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return this.View(new NavViewModelFactory().Create());
        }
    }
}