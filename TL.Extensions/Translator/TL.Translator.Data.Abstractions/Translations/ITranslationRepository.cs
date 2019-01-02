using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Data.Abstractions.Translations
{
    public interface ITranslationRepository : IRepository
    {
        void Add(Translation translation);

        Translation GetById(Guid id);

        IEnumerable<Translation> GetByUser(User user);

        IEnumerable<Translation> GetAll();
    }
}
