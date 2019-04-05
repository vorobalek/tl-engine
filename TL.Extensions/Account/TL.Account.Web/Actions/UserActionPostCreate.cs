using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Entities.Relationships;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Actions;

namespace TL.Account.Web.Actions
{
    public class UserActionPostCreate : IEntityActionPostCreate<User>
    {
        public bool Invoke(User entity, IServiceProvider serviceProvider)
        {
            var storage = serviceProvider.GetService<IStorage>();
            var repository = storage.GetRepository<ISubscriptionRepository>();
            var item = repository.Get(e => e.FromId == entity.Id && e.ToId == User.System.Id);

            if (item == null)
            {
                repository.Add(new Subscription()
                {
                    From = entity,
                    ToId = User.System.Id,
                });
            }

            return true;
        }
    }
}
