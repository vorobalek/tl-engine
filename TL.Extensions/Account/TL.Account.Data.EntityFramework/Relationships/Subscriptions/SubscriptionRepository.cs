using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.EntityFramework.Relationships.Subscriptions
{
    public class SubscriptionRepository : EntityRepository<Subscription>, ISubscriptionRepository
    {
        public IEnumerable<Guid> Followers(User user)
        {
            return Followers(user.Id);
        }

        public IEnumerable<Guid> Followers(Guid userId)
        {
            return dbSet.Where(s => s.ToId == userId).Select(s => s.FromId);
        }

        public IEnumerable<Guid> Friends(User user)
        {
            return Friends(user.Id);
        }

        public IEnumerable<Guid> Friends(Guid userId)
        {
            return Subscriptions(userId).Intersect(Followers(userId));
        }

        public IEnumerable<Guid> Subscriptions(User user)
        {
            return Subscriptions(user.Id);
        }

        public IEnumerable<Guid> Subscriptions(Guid userId)
        {
            return dbSet.Where(s => s.FromId == userId).Select(s => s.ToId);
        }
    }
}
