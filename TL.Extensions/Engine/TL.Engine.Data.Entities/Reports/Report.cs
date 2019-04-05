using System;
using System.ComponentModel.DataAnnotations;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Reports
{
    public enum ReportPriority
    {
        [Display(Name = "Незначительная")]
        Minor,

        [Display(Name = "Регулярная")]
        Medium,

        [Display(Name = "Значительная")]
        Fatal,

        [Display(Name = "Невозможно работать")]
        Blocker
    }

    public class Report : EntityComparableStored<Guid>
    {
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public ReportPriority? Priority { get; set; }

        public Report() : base()
        {
        }
    }
}
