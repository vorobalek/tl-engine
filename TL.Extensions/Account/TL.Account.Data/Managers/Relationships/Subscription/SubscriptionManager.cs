using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Account.Data.Entities.Relationships;
using TL.Engine.SDK.Managers;

namespace TL.Account.Data.Managers
{
    public class SubscriptionManager : EntityManager<Subscription>, ISubscriptionManager
    {
        public SubscriptionManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
