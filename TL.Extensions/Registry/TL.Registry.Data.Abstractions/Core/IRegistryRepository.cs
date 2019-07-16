using System;
using TL.Engine.SDK.Repositories;

namespace TL.Registry.Data.Abstractions.Core
{
    public interface IRegistryRepository : IEntityComparableRepository<Entities.Core.Registry, Guid>
    {
    }
}
