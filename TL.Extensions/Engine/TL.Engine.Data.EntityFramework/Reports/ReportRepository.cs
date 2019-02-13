using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Reports;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ReportRepository : EntityRepository<Report>, IReportRepository
    {
        public void Add(Report report)
        {
            dbSet.Add(report);
        }

        public IEnumerable<Report> GetAll()
        {
            return dbSet.OrderBy(e => e.CreationDate).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public Report GetById(Guid id)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id == id));
        }
    }
}
