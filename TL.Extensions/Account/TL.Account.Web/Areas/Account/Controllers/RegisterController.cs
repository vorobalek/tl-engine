using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class RegisterController : __AccountController__
    {
        public RegisterController(IStorage storage) : base(storage)
        {
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(string returnUrl = null)
        {
           return View(new RegisterViewModel() { ReturnUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Content("~/") });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegisterViewModel model)
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
    }
}
