using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using TL.Account.Data.Entities.Relationships;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Account.Data.Managers
{
    internal class SubscriptionManager : EntityManager<Subscription>, ISubscriptionManager
    {
        public SubscriptionManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
