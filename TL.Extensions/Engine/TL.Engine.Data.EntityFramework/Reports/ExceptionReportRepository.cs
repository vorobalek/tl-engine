using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Reports;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ExceptionReportRepository : RepositoryBase<Report>, IExceptionReportRepository
    {
        public void Add(Report report)
        {
            dbSet.Add(report);
        }

        public IEnumerable<Report> GetAll()
        {
            return dbSet.OrderBy(e => e.CreationDate);
        }

        public Report GetById(Guid id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }
    }
}
