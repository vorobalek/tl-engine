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
    internal class GroupManager : EntityComparableManager<Group, Guid>, IGroupManager
    {
        public GroupManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public IEnumerable<Group> GetByUser(User user)
        {
            var userGroups = Storage.GetRepository<IUserGroupRepository>().GetByUser(user);
            return userGroups.Select(ug => GetByKey(ug.GroupId));
        }
    }
}
