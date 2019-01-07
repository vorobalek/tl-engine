using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Account.Data.Abstractions.Security;
using TL.Translator.Data.Abstractions.Translations;
using TL.Translator.Web.Areas.Translator.ViewModels.History;

namespace TL.Translator.Web.Areas.Translator.Controllers
{
    [Authorize]
    public class HistoryController : __TranslatorController__
    {
        public HistoryController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            var user = Storage.GetRepository<IUserRepository>().GetByUsername(User.Identity.Name);
            var translations = Storage.GetRepository<ITranslationRepository>().GetByUser(user);
            return View(new HistoryViewModelFactory().Create(translations));
        }
    }
}
