using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Api.SDK.Attributes.Executable;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class StringVariableManager : EntityComparableStoredManager<StringVariable, Guid>, IStringVariableManager
    {
        public StringVariableManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        [PrivateApi(Description = "Получить все строковые переменные")]
        public override IEnumerable<StringVariable> GetAll()
        {
            return base.GetAll();
        }
    }
}
