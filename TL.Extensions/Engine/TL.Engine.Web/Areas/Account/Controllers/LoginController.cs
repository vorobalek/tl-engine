using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;
using TL.Engine.Web.Areas.Account.ViewModels;

namespace TL.Engine.Web.Areas.Account.Controllers
{
    public class LoginController : __AccountController__
    {
        public LoginController(IUserManager userManager) : base(userManager)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect(Url.Content("/"));

            return View(new LoginViewModel() { ReturnUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Content("~/") });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel model)
        {
            if (User.Identity.IsAuthenticated)
                return Redirect(Url.Content("/"));

            if (ModelState.IsValid)
            {
                if (UserManager.Get(model.Username) is User user && !user.IsClosed)
                {
                    if (user.HasPassword)
                    {
                        if (string.IsNullOrWhiteSpace(model.Password))
                        {
                            ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                            return View(model);
                        }

                        var passwordHasher = new PasswordHasher<User>();
                        var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password);

                        if (result == PasswordVerificationResult.Failed)
                        {
                            ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                            return View(model);
                        }
                    }
                    UserManager.Authenticate(user, HttpContext);
                    return Redirect(model.ReturnUrl);
                }
                ModelState.AddModelError(string.Empty, "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
    }
}
