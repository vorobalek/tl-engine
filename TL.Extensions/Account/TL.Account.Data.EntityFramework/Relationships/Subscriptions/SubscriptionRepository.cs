using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Relationships.Subscriptions
{
    public class SubscriptionRepository : RepositoryBase<Subscription>, ISubscriptionRepository
    {
        public void Add(User from, User to)
        {
            Add(from.Id, to.Id);
        }

        public void Add(Guid from, Guid to)
        {
            dbSet.Add(new Subscription() { FromId = from, ToId = to });
        }

        public void Delete(User from, User to)
        {
            Delete(from.Id, to.Id);
        }

        public void Delete(Guid from, Guid to)
        {
            dbSet.Remove(new Subscription() { FromId = from, ToId = to });
        }

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
