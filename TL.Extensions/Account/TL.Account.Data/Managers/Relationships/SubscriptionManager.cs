using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Account.Data.Entities.Relationships;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Account.Data.Managers
{
    internal class SubscriptionManager : EntityComparableManager<Subscription, (Guid, Guid)>, ISubscriptionManager
    {
        public SubscriptionManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
