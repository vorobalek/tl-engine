using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Engine.Data.EntityFramework.Reports
{
    public class ReportRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new ReportConfiguration());
        }
    }
}
