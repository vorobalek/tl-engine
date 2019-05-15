using System;
using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class UserRoleManager : EntityManager<UserRole>, IUserRoleManager
    {
        public UserRoleManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
