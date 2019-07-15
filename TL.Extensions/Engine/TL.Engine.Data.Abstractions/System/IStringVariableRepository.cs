using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.System
{
    public interface IStringVariableRepository : IEntityComparableRepository<StringVariable, Guid>
    {
        IEnumerable<StringVariable> GetByName(string name);

        IEnumerable<StringVariable> GetByAuthor(User user);

        IEnumerable<StringVariable> GetByAuthorId(Guid guid);
    }
}
