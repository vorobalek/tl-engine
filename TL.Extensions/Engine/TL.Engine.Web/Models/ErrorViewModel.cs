using System;
using System.ComponentModel.DataAnnotations;
using TL.Engine.Data.Entities.Reports;

namespace TL.Engine.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int StatusCode { get; set; }

        public string ReturnUrl { get; set; }

        public string StatusMessage { get; set; }

        [Required(ErrorMessage = "Вы не представились")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Опишите проблему")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Нельзя отправить отчёт без ошибок!")]
        public string Message { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Нельзя отправить пустой отчёт!")]
        public string StackTrace { get; set; }

        [Required(ErrorMessage = "На сколько проблема критична?")]
        public ReportPriority? Priority { get; set; }

        public DateTime Date { get; set; }
    }
}
