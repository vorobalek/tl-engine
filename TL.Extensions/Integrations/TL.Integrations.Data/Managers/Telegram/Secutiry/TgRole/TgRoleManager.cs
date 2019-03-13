using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    public class TgRoleManager : EntityComparableStoredManager<TgRole, Guid>, ITgRoleManager
    {
        public TgRoleManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
