using ExtCore.Data.Abstractions;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Translator.Data.Abstractions.Translations;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Data.Entities.Extensions
{
    public static class UserExtension
    {
        public static IEnumerable<Translation> GetTranslations(this User user, IStorage storage)
        {
            return storage.GetRepository<ITranslationRepository>().GetByUser(user);
        }
    }
}
