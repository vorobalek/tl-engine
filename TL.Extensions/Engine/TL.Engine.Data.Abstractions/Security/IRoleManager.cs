using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IRoleManager : IEntityComparableManager<Role, Guid>
    {
        IEnumerable<Role> GetByUser(User user);
    }
}
