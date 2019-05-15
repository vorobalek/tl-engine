using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.Data.Entities.Security;

namespace TL.Account.Web.Areas.Account.ViewModels
{
    public class IndexViewModel
    {
        public string StatusMessage { get; set; }
        public class ChangePwdModel
        {
            public string OldPasword { get; set; }
            public string NewPasword { get; set; }
            public string ConfirmNewPasword { get; set; }
        }

        public User User { get; set; }

        [BindProperty]
        public ChangePwdModel ChangePwd { get; set; }
    }
}
