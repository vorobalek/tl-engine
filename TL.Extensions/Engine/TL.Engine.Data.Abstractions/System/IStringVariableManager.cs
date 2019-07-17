using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IStringVariableManager : IEntityComparableManager<StringVariable, Guid>
    {
        StringVariable Get(string name);

        [PrivateApi(Description = "Получить все строковые переменные")]
        new IEnumerable<StringVariable> GetAll(bool loadDeleted = false);
    }
}
