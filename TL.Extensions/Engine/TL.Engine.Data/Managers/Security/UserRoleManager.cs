using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class UserRoleManager : EntityManager<UserRole>, IUserRoleManager
    {
        public UserRoleManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
