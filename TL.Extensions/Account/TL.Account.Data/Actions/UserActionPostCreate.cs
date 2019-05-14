using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Account.Data.Managers;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Actions;

namespace TL.Account.Web.Actions
{
    public class UserActionPostCreate : IEntityActionPostCreate<User>
    {
        public bool Invoke(ref User entity, IServiceProvider serviceProvider, bool cacheOnly = false)
        {
            var subscriptionManager = serviceProvider.GetService<ISubscriptionManager>();
            var userId = entity.Id;
            var item = subscriptionManager.Get(e => e.FromId == userId && e.ToId == User.System.Id);
            if (item == null)
            {
                var subsription = subscriptionManager.CreateEmpty(cacheOnly: true);
                subsription.FromId = userId;
                subsription.ToId = User.System.Id;
                subscriptionManager.Create(subsription, cacheOnly);
            }

            return true;
        }
    }
}
