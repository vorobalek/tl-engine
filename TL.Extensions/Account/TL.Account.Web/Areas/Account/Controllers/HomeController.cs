using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Account.Web.Areas.Account.Models;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        public IActionResult Index()
        {
            var user = Storage.GetRepository<IUserRepository>().GetByUsername(HttpContext.User.Identity.Name);
            return View(user);
        }

        [Authorize(Policy = "SA")]
        public IActionResult BigRedButton()
        {
            return View();
        }

        public IActionResult Exception()
        {
            throw new NotImplementedException("Test Exception");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SetPassword(SetPasswordComponentModel model)
        {
            if (ModelState.IsValid)
            {
                var passwordHasher = new PasswordHasher<User>();
                var user = Storage.GetRepository<IUserRepository>().GetByUsername(HttpContext.User.Identity.Name);
                user.PasswordHash = passwordHasher.HashPassword(user, model.Password);
                Storage.GetRepository<IUserRepository>().Update(user);
                Storage.Save();
                return RedirectToAction("Index", "Home");
            }
            return ViewComponent("SetPassword", model);
        }

        IStorage Storage { get; }

        public HomeController(IStorage storage)
        {
            Storage = storage;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = Storage.GetRepository<IUserRepository>().GetByUsername(model.Username);
                if (user != null)
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
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = Storage.GetRepository<IUserRepository>().GetByUsername(model.Username);
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
                        })
                    };
                    Storage.GetRepository<IUserRepository>().Add(user);
                    Storage.Save();

                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
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
