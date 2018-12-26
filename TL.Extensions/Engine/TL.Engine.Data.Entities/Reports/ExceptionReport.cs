using ExtCore.Data.Entities.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;

namespace TL.Engine.Data.Entities.Reports
{
    public enum ExceptionReportPriority
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

    public class ExceptionReport : IEntity
    {
        public Guid Id { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public ExceptionReportPriority? Priority { get; set; }

        public DateTime Date { get; set; }
    }
}
