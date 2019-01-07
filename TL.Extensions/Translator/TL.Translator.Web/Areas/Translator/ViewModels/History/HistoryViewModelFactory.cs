using System.Collections.Generic;
using System.Linq;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Web.Areas.Translator.ViewModels.History
{
    public class HistoryViewModelFactory
    {
        public HistoryViewModel Create(IEnumerable<Translation> translations)
        {
            return new HistoryViewModel()
            {
                Histories = translations.Select(t => new HistoryItemViewModelFactory().Create(t))
            };
        }
    }
}
