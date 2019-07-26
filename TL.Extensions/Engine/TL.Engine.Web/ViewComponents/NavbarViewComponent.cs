using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.ViewComponents;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.ViewComponents
{
    public class NavbarViewComponent : ActivatorViewComponent
    {
        public NavbarViewComponent(IActivatorService activator) : base(activator)
        {
        }

        public IViewComponentResult Invoke()
        {
            return View(new LinksViewModelFactory()
                .Create(Activator, UserClaimsPrincipal
                .Claims
                .Where(c => c.Type == ClaimsIdentity.DefaultRoleClaimType)
                .Select(c => c.Value), "NavbarItems"));
        }
    }
}