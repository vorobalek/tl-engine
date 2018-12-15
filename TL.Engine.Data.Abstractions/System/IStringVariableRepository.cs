using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.Abstractions.System
{
    public interface IStringVariableRepository : IRepository
    {
        IEnumerable<StringVariable> GetAll();

        StringVariable GetById(Guid id);

        IEnumerable<StringVariable> GetByName(string name);
    }
}
