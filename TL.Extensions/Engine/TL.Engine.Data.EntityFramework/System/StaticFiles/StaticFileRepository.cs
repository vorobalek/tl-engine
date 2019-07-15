using System;
using TL.Engine.Data.Abstractions.System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.System.StaticFiles
{
    public class StaticFileRepository : EntityComparableRepository<StaticFile, Guid>, IStaticFileRepository
    {
    }
}
