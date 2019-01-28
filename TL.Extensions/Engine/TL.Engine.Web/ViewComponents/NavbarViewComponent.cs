using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new LinksViewModelFactory()
                .Create(UserClaimsPrincipal
                .Claims
                .Where(c => c.Type == ClaimsIdentity.DefaultRoleClaimType)
                .Select(c => c.Value), "NavbarItems"));
        }
    }
}