using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Core;

namespace TL.Registry.Data.EntityFramework.Core.Registries
{
    public class RegistryRepository : EntityComparableRepository<Entities.Core.Registry, Guid>, IRegistryRepository
    {
    }
}
