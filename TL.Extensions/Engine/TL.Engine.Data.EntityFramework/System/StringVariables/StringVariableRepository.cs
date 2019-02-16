using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Entities.Security;
using TL.Engine.Data.Abstractions.System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.System.StringVariables
{
    public class StringVariableRepository : EntityComparableStoredRepository<StringVariable, Guid>, IStringVariableRepository
    {
        public IEnumerable<StringVariable> GetByAuthor(User user)
        {
            return GetByAuthorId(user.Id);
        }

        public IEnumerable<StringVariable> GetByAuthorId(Guid guid)
        {
            return dbSet.Where(obj => obj.AuthorId == guid).OrderBy(obj => obj.Name).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public IEnumerable<StringVariable> GetByName(string name)
        {
            return dbSet.Where(obj => obj.Name == name).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id))); ;
        }
    }
}
