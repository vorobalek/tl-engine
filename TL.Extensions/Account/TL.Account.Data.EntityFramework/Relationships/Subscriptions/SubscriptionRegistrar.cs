using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
