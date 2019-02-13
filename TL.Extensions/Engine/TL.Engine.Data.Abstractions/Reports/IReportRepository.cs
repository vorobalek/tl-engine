using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Reports
{
    public interface IReportRepository : IEntityRepository<Report>
    {
        IEnumerable<Report> GetAll();

        Report GetById(Guid id);

        void Add(Report report);
    }
}
