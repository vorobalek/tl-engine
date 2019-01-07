using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Globalization;

namespace TL.Translator.Web.Areas.Translator.ViewModels.Home
{
    public class TranslateViewModel
    {
        public bool IsReady { get; set; } = false;

        public bool IsSwapped { get; set; } = false;

        public string Input { get; set; }

        public string InputCulture { get; set; }

        public string OutputCulture { get; set; }

        public string Output { get; set; }

        public IEnumerable<SelectListItem> AvailableInputCultures { get; set; }

        public IEnumerable<SelectListItem> AvailableOutputCultures { get; set; }

        public string StatusMessage { get; set; }

        public TranslateViewModel()
        {

        }

        public TranslateViewModel(IEnumerable<SelectListItem> availableCultures)
        {
            AvailableInputCultures = availableCultures;
        }
    }
}
