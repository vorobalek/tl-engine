using TL.Account.Data.Managers;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Actions;

namespace TL.Account.Web.Actions
{
    public class UserActionPostCreate : IEntityActionPostCreate<User>
    {
        ISubscriptionManager SubscriptionManager { get; }

        public UserActionPostCreate(ISubscriptionManager subscriptionManager)
        {
            SubscriptionManager = subscriptionManager;
        }

        public bool Invoke(ref User entity, bool cacheOnly = false)
        {
            var userId = entity.Id;
            var item = SubscriptionManager.Get(e => e.FromId == userId && e.ToId == User.System.Id);
            if (item == null)
            {
                var subsription = SubscriptionManager.CreateEmpty(cacheOnly: true);
                subsription.FromId = userId;
                subsription.ToId = User.System.Id;
                SubscriptionManager.Create(subsription, cacheOnly);
            }

            return true;
        }
    }
}
