using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.EntityFramework.Security.Roles
{
    public class RoleRepository : EntityRepository<Role>, IRoleRepository
    {
        public IEnumerable<Role> GetAll()
        {
            return dbSet.OrderBy(obj => obj.Name).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public Role GetById(Guid id)
        {
            return Load(dbSet.SingleOrDefault(obj => obj.Id == id));
        }

        public Role GetByName(string name)
        {
            return Load(dbSet.SingleOrDefault(obj => obj.Name == name));
        }
    }
}
