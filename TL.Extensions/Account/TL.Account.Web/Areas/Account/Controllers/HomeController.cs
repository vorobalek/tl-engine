using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        public IHostingEnvironment HostingEnvironment { get; }

        public HomeController(IStorage storage, IHostingEnvironment appEnvironment) : base(storage)
        {
            HostingEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var user = Storage.GetRepository<IUserRepository>().GetByUsername(HttpContext.User.Identity.Name);
            return View(new IndexViewModel()
            {
                Username = user.Username,
                HasPassword = user.HasPassword
            });
        }
        
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var ReturnUrl = returnUrl ?? Request.Headers["Referer"].ToString();
            return Redirect(Url.IsLocalUrl(ReturnUrl) ? ReturnUrl : Url.Content("~/"));
        }
    }
}
