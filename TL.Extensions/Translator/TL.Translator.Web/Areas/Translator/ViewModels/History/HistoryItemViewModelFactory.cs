using System.Globalization;
using TL.Translator.Data.Entities.Translations;

namespace TL.Translator.Web.Areas.Translator.ViewModels.History
{
    public class HistoryItemViewModelFactory
    {
        public HistoryItemViewModel Create(Translation translation)
        {
            return new HistoryItemViewModel()
            {
                Input = translation.InputText,
                InputCulture = new CultureInfo(translation.InputCulture ?? "en").DisplayName,
                Output = translation.OutputText,
                OutputCulture = new CultureInfo(translation.OutputCulture ?? "ru").DisplayName,
                Date = translation.Date
            };
        }
    }
}
