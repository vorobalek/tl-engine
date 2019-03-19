using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TL.Api.Data.Entities.Security;

namespace TL.Api.Web.Areas.ApiHelp.ViewModels.Settings
{
    public class IndexViewModel
    {
        public class InputModel
        {
            public Guid TokenId { get; set; }
        }

        [BindProperty]
        public InputModel BindModel { get; set; }

        public IEnumerable<Token> Tokens { get; set; }
    }
}