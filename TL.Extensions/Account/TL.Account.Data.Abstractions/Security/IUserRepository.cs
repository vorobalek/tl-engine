using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserRepository : IEntityComparableStoredRepository<User, Guid>
    {
        User GetByUsername(string username);
    }
}
