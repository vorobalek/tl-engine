using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    public class RoleManager : EntityComparableStoredManager<Role, Guid>, IRoleManager
    {
        public RoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        [PublicApi(Description = "Получить роль по Id")]
        public override Role Get(Guid key, bool loadDeleted = false)
        {
            return base.Get(key, loadDeleted);
        }
    }
}
