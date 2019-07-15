using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class ReportManager : EntityComparableManager<Report, Guid>, IReportManager
    {
        public ReportManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
