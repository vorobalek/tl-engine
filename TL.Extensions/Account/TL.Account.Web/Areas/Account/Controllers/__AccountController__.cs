using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Account.Data.Managers.User;
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
