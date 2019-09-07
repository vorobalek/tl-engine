using Microsoft.AspNetCore.Mvc;
using TL.Engine.Web.Areas.Admin.ViewModels.Users;

namespace TL.Engine.Web.Areas.Admin.Controllers
{

    public class UsersController : __AdminController__
    {
        public IActionResult Index()
        {
            return View("Index", new IndexViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                var createModel = model.CreateUserModel;
                if (string.IsNullOrWhiteSpace(createModel.Username))
                {
                    model.Message = "Требуется указать логин!";
                    return View("Index", model);
                }
                if (string.IsNullOrWhiteSpace(createModel.Password))
                {
                    model.Message = "Требуется указать пароль!";
                    return View("Index", model);
                }

                /// Тут будем создавать юзера. Ещё прикрутить крисивую выборку списка ролей и групп.

                return View("Index", model);
            }
            return Index();
        }
    }
}
