using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    public class UserGroupManager : EntityManager<UserGroup>, IUserGroupManager
    {
        public UserGroupManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
