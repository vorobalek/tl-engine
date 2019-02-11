using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TL.Account.Data.Extensions;
using TL.Account.Data.Managers;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        public IHostingEnvironment HostingEnvironment { get; }

        public HomeController(IStorage storage, IUserManager userManager, IHostingEnvironment appEnvironment) : base(storage, userManager)
        {
            HostingEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var user = User.GetUser(Storage);
            return View(new IndexViewModel()
            {
                Username = user.Username,
                HasPassword = user.HasPassword
            });
        }
    }
}
