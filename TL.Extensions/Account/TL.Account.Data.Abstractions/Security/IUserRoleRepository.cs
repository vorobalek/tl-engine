using ExtCore.Data.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserRoleRepository : IRepository
    {
        IEnumerable<UserRole> GetByRole(Role role);

        IEnumerable<UserRole> GetByRoleId(Guid roleId);

        IEnumerable<UserRole> GetByUser(User User);

        IEnumerable<UserRole> GetByUserId(Guid userId);
    }
}
