using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Registry.Data.Abstractions.Security;

namespace TL.Registry.Data.Managers
{
    internal class RegistryManager : EntityComparableManager<Entities.Core.Registry, Guid>, IRegistryManager
    {
        public RegistryManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public IEnumerable<Entities.Core.Registry> GetAllowedForGroup(Group group)
        {
            var all = GetAll(true);
            var result = new List<Entities.Core.Registry>();
            foreach (var registry in all)
            {
                var userPermissions = Storage.GetRepository<IUserPermissionRepository>().Get((registry.OwnerId, registry.Id));
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Core.Registry> GetAllowedForUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
