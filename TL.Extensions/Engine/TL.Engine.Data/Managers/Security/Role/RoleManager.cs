using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class RoleManager : EntityComparableStoredManager<Role, Guid>, IRoleManager
    {
        public RoleManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        [PrivateApi(Description = "Получить роль по Id")]
        public override Role Get(Guid key, bool loadDeleted = false)
        {
            return base.Get(key, loadDeleted);
        }
    }
}
