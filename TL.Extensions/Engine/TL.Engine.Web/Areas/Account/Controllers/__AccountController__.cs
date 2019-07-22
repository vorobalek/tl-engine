using Microsoft.AspNetCore.Mvc;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Controllers;

namespace TL.Engine.Web.Areas.Account.Controllers
{
    [Area("Account")]
    public abstract class __AccountController__ : BaseController
    {
        public __AccountController__(IUserManager userManager) : base()
        {
            UserManager = userManager;
        }

        protected IUserManager UserManager { get; }
    }
}
