using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Translator.Data.Entities.Translations;

namespace TL.Account.Web.Areas.Account.ViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool HasPassword { get; set; }

        public IEnumerable<Translation> Translations { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}
