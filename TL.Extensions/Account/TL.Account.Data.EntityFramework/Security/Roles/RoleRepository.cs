using System;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.EntityFramework.Security.Roles
{
    public class RoleRepository : EntityComparableStoredRepository<Role, Guid>, IRoleRepository
    {
        public Role GetByName(string name)
        {
            return Load(dbSet.FirstOrDefault(obj => obj.Name == name));
        }
    }
}
