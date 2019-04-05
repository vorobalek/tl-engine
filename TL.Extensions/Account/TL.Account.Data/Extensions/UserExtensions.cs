using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Abstractions.Relationships;
using TL.Engine.Data.Entities.Security;

namespace TL.Account.Data.Extensions
{
    public static class UserExtensions
    {
        public static IEnumerable<Guid> GetFollowersUids(this User user, IStorage storage)
        {
            var followers = storage.GetRepository<ISubscriptionRepository>().Followers(user);
            return followers;
        }

        public static IEnumerable<Guid> GetSubscriptionsUids(this User user, IStorage storage)
        {
            var subscriptions = storage.GetRepository<ISubscriptionRepository>().Subscriptions(user);
            return subscriptions;
        }
    }
}
