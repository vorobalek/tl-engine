using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Relationships
{
    public interface ISubscriptionRepository : IEntityRepository<Subscription>
    {
        IEnumerable<Guid> Followers(User user);

        IEnumerable<Guid> Followers(Guid userId);

        IEnumerable<Guid> Subscriptions(User user);

        IEnumerable<Guid> Subscriptions(Guid userId);

        IEnumerable<Guid> Friends(User user);

        IEnumerable<Guid> Friends(Guid userId);

        void Add(User from, User to);

        void Add(Guid from, Guid to);

        void Delete(User from, User to);

        void Delete(Guid from, Guid to);
    }
}
