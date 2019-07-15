using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Security
{
    public interface IGroupRepository : IEntityComparableRepository<Group, Guid>
    {
        Group GetByName(string name);
    }
}
