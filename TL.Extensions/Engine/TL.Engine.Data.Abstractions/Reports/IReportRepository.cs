using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Reports
{
    public interface IReportRepository : IEntityComparableStoredRepository<Report, Guid>
    {
    }
}
