using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    public class TgUserRoleManager : EntityManager<TgUserRole>, ITgUserRoleManager
    {
        public TgUserRoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
