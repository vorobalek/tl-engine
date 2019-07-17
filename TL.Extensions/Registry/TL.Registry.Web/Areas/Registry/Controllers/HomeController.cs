using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;
using TL.Registry.Data.Managers;
using TL.Registry.Web.Areas.Registry.ViewModels.Home;

namespace TL.Registry.Web.Areas.Registry.Controllers
{
    [Authorize]
    public class HomeController : __RegistryController__
    {
        IUserManager UserManager { get; }

        IGroupManager GroupManager { get; }

        IRoleManager RoleManager { get; }

        IRegistryManager RegistryManager { get; }

        public HomeController(IUserManager userManager, IGroupManager groupManager, IRoleManager roleManager, IRegistryManager registryManager)
        {
            UserManager = userManager;
            GroupManager = groupManager;
            RoleManager = roleManager;
            RegistryManager = registryManager;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = UserManager.GetByClaims(User);
                var groups = GroupManager.GetByUser(user);
                var roles = RoleManager.GetByUser(user);
                return View(new IndexViewModelFactory().Create(new[] { user }, groups, roles, RegistryManager));
            }
            return View(new IndexViewModelFactory().Empty());
        }
    }
}
