using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
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
    }
}
