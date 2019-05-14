using ExtCore.Data.Abstractions;
using TL.Engine.Data.Managers;
using TL.Account.SDK.Controllers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public abstract class __AccountController__ : BaseAccountController
    {
        public __AccountController__(IUserManager userManager)
        {
            UserManager = userManager;
        }

        protected IUserManager UserManager { get; }
    }
}
