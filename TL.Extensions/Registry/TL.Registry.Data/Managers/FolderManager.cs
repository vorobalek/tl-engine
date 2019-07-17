using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.Managers
{
    internal class FolderManager : EntityComparableManager<Folder, Guid>, IFolderManager
    {
        public FolderManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public IEnumerable<Folder> GetAllowedForGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Folder> GetAllowedForUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
