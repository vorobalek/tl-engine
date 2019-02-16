using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.System
{
    public interface IStringVariableRepository : IEntityComparableStoredRepository<StringVariable, Guid>
    {
        IEnumerable<StringVariable> GetByName(string name);

        IEnumerable<StringVariable> GetByAuthor(User user);

        IEnumerable<StringVariable> GetByAuthorId(Guid guid);
    }
}
