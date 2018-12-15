using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.EntityFramework.Security.Roles
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public IEnumerable<Role> GetAll()
        {
            return dbSet.OrderBy(obj => obj.Name);
        }

        public Role GetById(Guid id)
        {
            return dbSet.FirstOrDefault(obj => obj.Id == id);
        }

        public Role GetByName(string name)
        {
            return dbSet.FirstOrDefault(obj => obj.Name == name);
        }
    }
}
