using System;
using TL.Account.Data.Entities.Relationships;
using TL.Engine.SDK.Managers;

namespace TL.Account.Data.Managers
{
    public interface ISubscriptionManager : IEntityComparableManager<Subscription, (Guid, Guid)>
    {
    }
}