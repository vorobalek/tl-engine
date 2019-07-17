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
    internal class FileManager : EntityComparableManager<File, Guid>, IFileManager
    {
        public FileManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public IEnumerable<File> GetAllowedForGroup(Group group)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<File> GetAllowedForUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
