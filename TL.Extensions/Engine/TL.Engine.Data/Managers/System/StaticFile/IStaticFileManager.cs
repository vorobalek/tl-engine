using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IStaticFileManager : IEntityDuplicateComparableStoredManager<StaticFile, Guid>
    {
    }
}