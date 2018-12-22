using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Account.Web.Areas.Account.Models;

namespace TL.Account.Web.Areas.Account.Components
{
    public class SetPassword : ViewComponent
    {
        public IViewComponentResult Invoke(SetPasswordComponentModel model)
        {
            return View(model);
        }
    }
}
