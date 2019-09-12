using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.JustBot.Data.Entities.Common;

namespace TL.JustBot.Data.Managers
{
    internal class HistoryManager : EntityComparableManager<History, Guid>, IHistoryManager
    {
        public HistoryManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
