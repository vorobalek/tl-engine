using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.System
{
    public interface IStaticFileRepository : IEntityComparableRepository<StaticFile, Guid>
    {
    }
}
