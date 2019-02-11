using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Account.Data.Managers;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class LoginController : __AccountController__
    {
        public LoginController(IStorage storage, IUserManager userManager) : base(storage, userManager)
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
                User user = Storage.GetRepository<IUserRepository>().GetByUsername(model.Username);
                if (user != null && !user.IsClosed)
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
