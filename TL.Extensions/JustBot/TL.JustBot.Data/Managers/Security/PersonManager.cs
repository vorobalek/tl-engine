using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.Managers
{
    internal class PersonManager : EntityComparableManager<Person, Guid>, IPersonManager
    {
        public PersonManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
