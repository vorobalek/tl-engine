using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Reports;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ExceptionReportRepository : RepositoryBase<ExceptionReport>, IExceptionReportRepository
    {
        public void Add(ExceptionReport report)
        {
            dbSet.Add(report);
        }

        public IEnumerable<ExceptionReport> GetAll()
        {
            return dbSet.OrderBy(e => e.Date);
        }

        public ExceptionReport GetById(Guid id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }
    }
}
