using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.System
{
    public class StringVariableRepository : EntityRepository<StringVariable>, IStringVariableRepository
    {
        public IEnumerable<StringVariable> GetAll()
        {
            return dbSet.OrderBy(obj => obj.Name);
        }

        public StringVariable GetById(Guid id)
        {
            return dbSet.FirstOrDefault(obj => obj.Id == id);
        }

        public IEnumerable<StringVariable> GetByName(string name)
        {
            return dbSet.Where(obj => obj.Name == name);
        }
    }
}
