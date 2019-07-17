using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class RoleManager : EntityComparableManager<Role, Guid>, IRoleManager
    {
        public RoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public IEnumerable<Role> GetByUser(User user)
        {
            var userGroups = Storage.GetRepository<IUserRoleRepository>().GetByUser(user);
            return userGroups.Select(ur => Get(ur.RoleId));
        }
    }
}
