using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class UserGroupManager : EntityManager<UserGroup>, IUserGroupManager
    {
        public UserGroupManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
