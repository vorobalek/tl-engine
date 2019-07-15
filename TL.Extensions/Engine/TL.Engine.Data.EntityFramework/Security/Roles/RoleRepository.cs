using System;
using System.Linq;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Security.Roles
{
    public class RoleRepository : EntityComparableRepository<Role, Guid>, IRoleRepository
    {
        public Role GetByName(string name)
        {
            return Load(dbSet.FirstOrDefault(obj => obj.Name == name));
        }
    }
}
