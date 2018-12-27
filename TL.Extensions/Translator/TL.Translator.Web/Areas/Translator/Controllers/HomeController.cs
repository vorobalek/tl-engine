using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TL.Translator.Web.Areas.Translator.Models;
using Yandex.Translator;

namespace TL.Translator.Web.Areas.Translator.Controllers
{
    public class HomeController : __TranslatorController__
    {
        public IYandexTranslator Translator { get; }

        public List<SelectListItem> AvailableInputCultures { get; }

        public List<ITranslationPair> TranslationPairs { get; set; }

        public HomeController(IConfiguration configuration)
        {
            Translator = Yandex.Translator.Yandex.Translator(api => api.ApiKey(configuration["YandexTranslateApiKey"]).Format(ApiDataFormat.Json));
            TranslationPairs = Translator.TranslationPairs().ToList();

            AvailableInputCultures = TranslationPairs
                .ToList()
                .Select(it => it.FromLanguage)
                .Distinct()
                .Select(it => new SelectListItem()
                {
                    Text = new CultureInfo(it).DisplayName,
                    Value = it
                })
                .OrderBy(it => it.Text)
                .ToList();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TranslateViewModel(AvailableInputCultures) { Input = "Hello, World!" });
        }

        [HttpPost]
        public IActionResult Index(TranslateViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Input))
            {
                return PartialView("Translate", new TranslateViewModel(AvailableInputCultures));
            }

            if (string.IsNullOrWhiteSpace(model.InputCulture))
            {
                model.InputCulture = Translator.Detect(model.Input);
            }

            model.AvailableInputCultures = TranslationPairs
                .Select(it => it.FromLanguage)
                .Distinct()
                .Select(it => new SelectListItem()
                {
                    Text = new CultureInfo(it).DisplayName,
                    Value = it,
                    Selected = (it == model.InputCulture)
                })
                .OrderBy(it => it.Text)
                .ToList();

            if (string.IsNullOrWhiteSpace(model.OutputCulture))
            {
                model.OutputCulture = "ru";
            }

            var supportedCulturesForInput = TranslationPairs
                    .Where(it => it.FromLanguage == model.InputCulture);

            if (supportedCulturesForInput.FirstOrDefault(it => it.ToLanguage == model.OutputCulture) == null)
            {
                if (supportedCulturesForInput.FirstOrDefault(it => it.ToLanguage == "ru") == null)
                {
                    model.OutputCulture = supportedCulturesForInput.FirstOrDefault().ToLanguage;
                }
                else
                {
                    model.OutputCulture = "ru";
                }
            }

            model.AvailableOutputCultures = supportedCulturesForInput
                    .Select(it => new SelectListItem()
                    {
                        Text = new CultureInfo(it.ToLanguage).DisplayName,
                        Value = it.ToLanguage,
                        Selected = (it.ToLanguage == model.OutputCulture)
                    })
                    .OrderBy(it => it.Text)
                    .ToList();

            var translation = Translator
                .Translate(request =>
                    request.From(model.InputCulture)
                    .To(model.OutputCulture)
                    .Text(model.Input)
                    .Html()
                );

            model.Output = translation.Text;

            return PartialView("Translate", model);
        }
    }
}
