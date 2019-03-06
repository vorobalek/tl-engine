using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Crm.Data.Entities.Periphery;
using TL.Engine.SDK.Managers;

namespace TL.Crm.Data.Managers
{
    public class LeadPhoneManager : EntityComparableStoredManager<LeadPhone, Guid>, ILeadPhoneManager
    {
        public LeadPhoneManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
