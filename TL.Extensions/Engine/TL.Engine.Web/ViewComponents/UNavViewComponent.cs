using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class UNavViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<string> roles)
        {
            return this.View(new UNavViewModelFactory().Create(roles));
        }
    }
}