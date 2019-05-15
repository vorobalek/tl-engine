using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;
using static TL.Account.Web.Areas.Account.ViewModels.IndexViewModel;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Authorize]
    public class EditController : __AccountController__
    {
        public EditController(IUserManager userManager) : base(userManager)
        {
        }
    }
}
