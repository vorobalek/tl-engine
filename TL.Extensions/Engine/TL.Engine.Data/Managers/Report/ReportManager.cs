using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public class ReportManager : EntityComparableStoredManager<Report, Guid>, IReportManager
    {
        public ReportManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
