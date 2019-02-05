using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TL.Account.Data.Managers.User;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class LogoutController : __AccountController__
    {
        public LogoutController(IStorage storage, IUserManager userManager) : base(storage, userManager)
        {
        }

        public async Task<IActionResult> Index(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var ReturnUrl = returnUrl ?? Request.Headers["Referer"].ToString();
            return Redirect(Url.IsLocalUrl(ReturnUrl) ? ReturnUrl : Url.Content("~/"));
        }
    }
}
