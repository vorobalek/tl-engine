using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserRoleRepository : IEntityRepository<UserRole>
    {
        IEnumerable<UserRole> GetByRole(Role role);

        IEnumerable<UserRole> GetByRoleId(Guid roleId);

        IEnumerable<UserRole> GetByUser(User User);

        IEnumerable<UserRole> GetByUserId(Guid userId);
    }
}
