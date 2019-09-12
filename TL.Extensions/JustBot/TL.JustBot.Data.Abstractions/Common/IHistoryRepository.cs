using System;
using TL.Engine.SDK.Repositories;
using TL.JustBot.Data.Entities.Common;

namespace TL.JustBot.Data.Abstractions.Common
{
    public interface IHistoryRepository : IEntityComparableRepository<History, Guid>
    {
    }
}
