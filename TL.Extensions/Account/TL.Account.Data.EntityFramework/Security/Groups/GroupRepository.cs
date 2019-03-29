using System;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.EntityFramework.Security.Groups
{
    public class GroupRepository : EntityComparableStoredRepository<Group, Guid>, IGroupRepository
    {
        public Group GetByName(string name)
        {
            return Load(dbSet.FirstOrDefault(obj => obj.Name == name));
        }
    }
}
