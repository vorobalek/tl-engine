using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Globalization;

namespace TL.Translator.Web.Areas.Translator.Models
{
    public class TranslateViewModel
    {
        public string Input { get; set; }

        public CultureInfo DetectedCulture { get; set; }

        public string InputCulture { get; set; }

        public string OutputCulture { get; set; }

        public string Output { get; set; }

        public IEnumerable<SelectListItem> AvailableInputCultures { get; set; }

        public IEnumerable<SelectListItem> AvailableOutputCultures { get; set; }

        public TranslateViewModel()
        {

        }

        public TranslateViewModel(IEnumerable<SelectListItem> availableCultures)
        {
            AvailableInputCultures = availableCultures;
        }
    }
}
