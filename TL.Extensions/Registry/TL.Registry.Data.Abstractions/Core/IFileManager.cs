using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.Managers
{
    public interface IFileManager : IEntityComparableManager<File, Guid>
    {
        IEnumerable<File> GetAllowedForUser(User user);
        IEnumerable<File> GetAllowedForGroup(Group group);
    }
}
