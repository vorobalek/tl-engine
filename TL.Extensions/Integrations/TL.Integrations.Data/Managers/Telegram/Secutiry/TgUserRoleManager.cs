using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    internal class TgUserRoleManager : EntityComparableManager<TgUserRole, (Guid, Guid)>, ITgUserRoleManager
    {
        public TgUserRoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
