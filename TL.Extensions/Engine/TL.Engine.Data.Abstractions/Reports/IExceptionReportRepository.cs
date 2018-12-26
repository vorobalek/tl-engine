using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.Abstractions.Reports
{
    public interface IExceptionReportRepository : IRepository
    {
        IEnumerable<ExceptionReport> GetAll();

        ExceptionReport GetById(Guid id);

        void Add(ExceptionReport report);
    }
}
