using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Translator.Data.Abstractions.Translations;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        public IActionResult Index()
        {
            var user = Storage.GetRepository<IUserRepository>().GetByUsername(HttpContext.User.Identity.Name);
            return View(new IndexViewModel()
            {
                Username = user.Username,
                HasPassword = user.HasPassword,
                Translations = Storage.GetRepository<ITranslationRepository>().GetByUser(user),
                UserRoles = Storage.GetRepository<IUserRoleRepository>().GetByUser(user),
            });
        }

        IStorage Storage { get; }

        public HomeController(IStorage storage)
        {
            Storage = storage;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel() { ReturnUrl = returnUrl ?? Url.Content("~/") });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
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
                    await Authenticate(user);
                    return Redirect(model.ReturnUrl);
                }
                ModelState.AddModelError(string.Empty, "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            return View(new RegisterViewModel() { ReturnUrl = returnUrl ?? Url.Content("~/") });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = Storage.GetRepository<IUserRepository>().GetByUsername(model.Username);
                if (user == null)
                {
                    var passwordHasher = new PasswordHasher<User>();
                    var user_id = Guid.NewGuid();

                    user = new User()
                    {
                        Id = user_id,
                        Username = model.Username,
                        PasswordHash = passwordHasher.HashPassword(user, model.Password),
                        UserRoles = new HashSet<UserRole>(new[]
                        {
                            new UserRole()
                            {
                                UserId = user_id,
                                RoleId = Role.User.Id
                            }
                        }),
                        Subscriptions = new HashSet<Subscription>(new[]
                        {
                            new Subscription()
                            {
                                FromId = user_id,
                                ToId = Data.Entities.Security.User.System.Id,
                                Quiet = true,
                            }
                        })
                    };

                    Storage.GetRepository<IUserRepository>().Add(user);
                    Storage.Save();

                    await Authenticate(user);
                    return Redirect(model.ReturnUrl);
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username)
            };

            var roles = Storage.GetRepository<IUserRoleRepository>().GetByUser(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role.RoleId.ToString()));
            }

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Home");
        }
    }
}
