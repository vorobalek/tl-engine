using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Registry.Data.Managers
{
    public interface IRegistryManager : IEntityComparableManager<Entities.Core.Registry, Guid>
    {
        IEnumerable<Entities.Core.Registry> GetAllowedForUser(User user);
        IEnumerable<Entities.Core.Registry> GetAllowedForGroup(Group group);
    }
}
