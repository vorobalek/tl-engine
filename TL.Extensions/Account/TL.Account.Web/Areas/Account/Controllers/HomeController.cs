using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class HomeController : __AccountController__
    {
        public HomeController(IUserManager userManager) : base(userManager)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = UserManager.GetByClaims(User);
            return View(new IndexViewModel()
            {
                User = user
            });
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IndexViewModel model)
        {
            if (model?.ChangePwd == null)
            {
                throw new ArgumentNullException(nameof(model.ChangePwd));
            }

            if (ModelState.IsValid)
            {
                if (UserManager.GetByClaims(User) is User user)
                {
                    model.User = user;
                    if (!user.HasPassword || user.HasPassword && UserManager.ValidatePassword(user, model.ChangePwd.OldPasword))
                    {
                        if (model.ChangePwd.NewPasword == model.ChangePwd.ConfirmNewPasword)
                        {
                            if (!user.HasPassword || !UserManager.ValidatePassword(user, model.ChangePwd.NewPasword))
                            {
                                UserManager.ChangePassword(user, model.ChangePwd.NewPasword);
                                UserManager.Authenticate(user, HttpContext);
                                model.StatusMessage = "Ваш пароль был успешно обновлен!";
                            }
                            else
                            {
                                ModelState.AddModelError("", "Новый пароль не отличается от старого");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "Новый пароль введен неверно.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Старый пароль введен неверно.");
                    }
                }
            }
            return View(model);
        }
    }
}
