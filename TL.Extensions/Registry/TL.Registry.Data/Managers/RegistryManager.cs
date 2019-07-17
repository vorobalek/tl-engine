using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Registry.Data.Managers
{
    internal class RegistryManager : EntityComparableManager<Entities.Core.Registry, Guid>, IRegistryManager
    {
        public RegistryManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
