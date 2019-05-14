using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        IHostingEnvironment HostingEnvironment { get; }

        public HomeController(IUserManager userManager, IHostingEnvironment appEnvironment) : base(userManager)
        {
            HostingEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var user = UserManager.GetByClaims(User);
            return View(new IndexViewModel()
            {
                Username = user.Username,
                HasPassword = user.HasPassword
            });
        }
    }
}
