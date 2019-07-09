using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class RoleManager : EntityComparableStoredManager<Role, Guid>, IRoleManager
    {
        public RoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public override Role Get(Guid key, bool loadDeleted = false)
        {
            return base.Get(key, loadDeleted);
        }
    }
}
