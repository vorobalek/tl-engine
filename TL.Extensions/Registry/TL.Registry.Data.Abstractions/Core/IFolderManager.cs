using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.Managers
{
    public interface IFolderManager : IEntityComparableManager<Folder, Guid>
    {
        IEnumerable<Folder> GetAllowedForUser(User user);
        IEnumerable<Folder> GetAllowedForGroup(Group group);
    }
}
