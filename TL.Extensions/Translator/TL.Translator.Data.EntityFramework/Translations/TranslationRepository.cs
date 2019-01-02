using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Entities.Security;
using TL.Translator.Data.Abstractions.Translations;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Data.EntityFramework.Translations
{
    public class TranslationRepository : RepositoryBase<Translation>, ITranslationRepository
    {
        public void Add(Translation translation)
        {
            dbSet.Add(translation);
        }

        public IEnumerable<Translation> GetAll()
        {
            return dbSet.OrderByDescending(p => p.Date);
        }

        public Translation GetById(Guid id)
        {
            return dbSet.FirstOrDefault(it => it.Id == id);
        }

        public IEnumerable<Translation> GetByUser(User user)
        {
            return dbSet.Where(it => it.AuthorId == user.Id).OrderByDescending(p => p.Date);
        }
    }
}
