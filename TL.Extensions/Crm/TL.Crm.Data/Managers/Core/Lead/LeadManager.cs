using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Managers;

namespace TL.Crm.Data.Managers
{
    public class LeadManager : EntityDuplicateComparableStoredManager<Lead, Guid>, ILeadManager
    {
        public LeadManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
