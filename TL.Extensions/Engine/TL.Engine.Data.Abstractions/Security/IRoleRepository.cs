using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Security
{
    public interface IRoleRepository : IEntityComparableStoredRepository<Role, Guid>
    {
        Role GetByName(string name);
    }
}
