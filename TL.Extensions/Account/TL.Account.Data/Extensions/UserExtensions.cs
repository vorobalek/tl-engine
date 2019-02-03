using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Extensions
{
    public static class UserExtensions
    {
        public static IEnumerable<Guid> GetFollowers(this User user, IStorage storage)
        {
            var followers = storage.GetRepository<ISubscriptionRepository>().Followers(user);
            return followers;
        }

        public static IEnumerable<Guid> GetSubscriptions(this User user, IStorage storage)
        {
            var subscriptions = storage.GetRepository<ISubscriptionRepository>().Subscriptions(user);
            return subscriptions;
        }
    }
}
