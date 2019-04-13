using TL.Engine.SDK.Repositories;
using TL.Linker.Data.Abstractions.Core;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.EntityFramework.Core.Links
{
    public class LinkRepository : EntityComparableStoredRepository<Link, int>, ILinkRepository
    {
    }
}
