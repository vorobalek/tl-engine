using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.Abstractions.Core
{
    public interface IFolderRepository : IEntityComparableRepository<Folder, Guid>
    {
    }
}
