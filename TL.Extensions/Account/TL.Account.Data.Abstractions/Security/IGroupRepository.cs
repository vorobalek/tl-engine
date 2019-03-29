using System;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IGroupRepository : IEntityComparableStoredRepository<Group, Guid>
    {
        Group GetByName(string name);
    }
}
