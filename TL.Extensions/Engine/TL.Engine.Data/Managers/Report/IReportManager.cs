using System;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IReportManager : IEntityComparableStoredManager<Report, Guid>
    {
    }
}