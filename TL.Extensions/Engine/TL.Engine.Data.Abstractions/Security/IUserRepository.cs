using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Security
{
    public interface IUserRepository : IEntityComparableStoredRepository<User, Guid>
    {
        User GetByUsername(string username);
    }
}
