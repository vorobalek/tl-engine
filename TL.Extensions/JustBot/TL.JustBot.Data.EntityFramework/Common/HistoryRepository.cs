using System;
using TL.Engine.SDK.Repositories;
using TL.JustBot.Data.Abstractions.Common;
using TL.JustBot.Data.Entities.Common;

namespace TL.JustBot.Data.EntityFramework.Common
{
    public class HistoryRepository : EntityComparableRepository<History, Guid>, IHistoryRepository
    {
    }
}
