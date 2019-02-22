using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Managers;

namespace TL.Crm.Data.Managers
{
    public class ContractorManager : EntityComparableStoredManager<Contractor, Guid>, IContractorManager
    {
        public ContractorManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
