using System;
using TL.Engine.Data.Abstractions.System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.System.StaticFiles
{
    public class StaticFileRepository : EntityComparableStoredRepository<StaticFile, Guid>, IStaticFileRepository
    {
    }
}
