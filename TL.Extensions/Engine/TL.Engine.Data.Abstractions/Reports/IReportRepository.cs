using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Data.Abstractions.Reports
{
    public interface IReportRepository : IRepository
    {
        IEnumerable<Report> GetAll();

        Report GetById(Guid id);

        void Add(Report report);
    }
}
