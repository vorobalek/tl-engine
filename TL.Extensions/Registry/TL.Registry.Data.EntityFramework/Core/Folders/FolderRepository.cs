using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Core;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.Folders
{
    public class FolderRepository : EntityComparableRepository<Folder, Guid>, IFolderRepository
    {
    }
}
