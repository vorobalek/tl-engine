using ExtCore.Data.Abstractions;
using TL.Account.Data.Managers;
using TL.Account.SDK.Controllers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public abstract class __AccountController__ : BaseAccountController
    {
        public __AccountController__(IStorage storage, IUserManager userManager) : base(storage)
        {
            UserManager = userManager;
        }

        protected IUserManager UserManager { get; }
    }
}
