using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IGroupManager : IEntityComparableManager<Group, Guid>
    {
        IEnumerable<Group> GetByUser(User user);
    }
}