using System;
using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class GroupManager : EntityComparableStoredManager<Group, Guid>, IGroupManager
    {
        public GroupManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
