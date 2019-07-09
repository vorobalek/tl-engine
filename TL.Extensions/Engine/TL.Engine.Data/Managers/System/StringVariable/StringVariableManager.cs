using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class StringVariableManager : EntityComparableStoredManager<StringVariable, Guid>, IStringVariableManager
    {
        public StringVariableManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public StringVariable Get(string name)
        {
            return Get(e => e.Name == name);
        }

        public override IEnumerable<StringVariable> GetAll(bool loadDeleted = false)
        {
            return base.GetAll(loadDeleted);
        }
    }
}
