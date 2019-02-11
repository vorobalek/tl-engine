using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Account.Data.Managers;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class RegisterController : __AccountController__
    {
        public RegisterController(IStorage storage, IUserManager userManager) : base(storage, userManager)
        {
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect(Url.Content("/"));

            return View(new RegisterViewModel() { ReturnUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Content("~/") });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegisterViewModel model)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect(Url.Content("/"));

            if (ModelState.IsValid)
            {
                var user = UserManager.GetOrCreate(model.Username, model.Password);
                if (user != null)
                {
                    UserManager.Authenticate(user, HttpContext);
                    return Redirect(model.ReturnUrl);
                }
                else
                    ModelState.AddModelError("", $"Похоже, что логин {model.Username} уже занят.");
            }
            return View(model);
        }
    }
}
