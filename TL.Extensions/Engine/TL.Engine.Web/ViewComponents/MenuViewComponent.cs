using Microsoft.AspNetCore.Mvc;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return this.View(new MenuViewModelFactory().Create());
        }
    }
}