using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Reports;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ReportRepository : EntityComparableRepository<Report, Guid>, IReportRepository
    {
    }
}
