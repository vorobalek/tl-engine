using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Account.Data.EntityFramework.Relationships.Subscriptions
{
    public class SubscriptionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new SubscriptionConfiguration());
        }
    }
}
