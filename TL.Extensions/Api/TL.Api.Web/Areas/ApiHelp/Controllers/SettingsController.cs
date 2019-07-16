using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Api.Data.Entities.Security;
using TL.Api.Data.Managers;
using TL.Api.Web.Areas.ApiHelp.ViewModels.Settings;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    [Authorize(Roles = "sa")]
    public class SettingsController : __ApiHelpController__
    {
        public IUserManager UserManager { get; }

        public ITokenManager TokenManager { get; }

        public IStorage Storage { get; }

        public SettingsController(IUserManager userManager, ITokenManager tokenManager, IStorage storage)
        {
            UserManager = userManager;
            TokenManager = tokenManager;
            Storage = storage;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create(UserManager, TokenManager));
        }

        [HttpPost]
        public IActionResult Add()
        {
            var user = UserManager.GetByClaims(User);
            var token = TokenManager.Create(new Token()
            {
                OwnerId = user.Id
            });

            return Redirect("/apihelp/settings/");
        }

        [HttpPost]
        public IActionResult Restore(IndexViewModel model)
        {
            var guid = model.BindModel.TokenId;
            {
                var token = TokenManager.Get(guid);
                if (token != null)
                {
                    token.IsDeleted = false;
                    TokenManager.Update(token);
                }
            }

            return Redirect("/apihelp/settings/");
        }

        [HttpPost]
        public IActionResult Remove(IndexViewModel model)
        {
            var guid = model.BindModel.TokenId;
            {
                var token = TokenManager.Get(guid);
                if (token != null)
                {
                    TokenManager.Remove(token);
                }
            }
            return Redirect("/apihelp/settings/");
        }

        [HttpPost]
        public IActionResult Delete(IndexViewModel model)
        {
            var guid = model.BindModel.TokenId;
            {
                var token = TokenManager.Get(guid);
                if (token != null)
                {
                    TokenManager.Delete(token);
                }
            }
            return Redirect("/apihelp/settings/");
        }
    }
}
