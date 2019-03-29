using System;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IRoleRepository : IEntityComparableStoredRepository<Role, Guid>
    {
        Role GetByName(string name);
    }
}
