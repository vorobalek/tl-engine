using System.Collections.Generic;

namespace TL.Translator.Web.Areas.Translator.ViewModels.History
{
    public class HistoryViewModel
    {
        public IEnumerable<HistoryItemViewModel> Histories { get; set; }
    }
}
