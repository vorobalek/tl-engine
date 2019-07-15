using System;
using TL.Engine.SDK.Repositories;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Abstractions.Core
{
    public interface ILinkRepository : IEntityComparableRepository<Link, Guid>
    {
    }
}
