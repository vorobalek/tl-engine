using System;

namespace TL.Translator.Web.Areas.Translator.ViewModels.History
{
    public class HistoryItemViewModel
    {
        public string InputCulture { get; set; }

        public string Input { get; set; }

        public string OutputCulture { get; set; }

        public string Output { get; set; }

        public DateTime Date { get; set; }
    }
}