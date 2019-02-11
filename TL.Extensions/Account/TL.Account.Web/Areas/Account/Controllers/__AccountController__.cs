using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Account.Data.Managers;
using TL.Engine.SDK.Controllers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Area("Account")]
    public abstract class __AccountController__ : BaseController
    {
        public __AccountController__(IStorage storage, IUserManager userManager) : base(storage)
        {
            UserManager = userManager;
        }

        protected IUserManager UserManager { get; }
    }
}
