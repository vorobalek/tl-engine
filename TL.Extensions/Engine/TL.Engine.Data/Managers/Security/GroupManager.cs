using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
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
    }
}
