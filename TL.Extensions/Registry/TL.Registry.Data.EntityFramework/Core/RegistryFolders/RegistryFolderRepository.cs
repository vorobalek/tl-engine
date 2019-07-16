using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Core;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.RegistryFolders
{
    public class RegistryFolderRepository : EntityComparableRepository<RegistryFolder, Guid>, IRegistryFolderRepository
    {
    }
}
