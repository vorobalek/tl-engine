using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Translator.Data.Abstractions.Translations;
using TL.Translator.Web.Areas.Translator.ViewModels.Home;
using Yandex.Translator;

namespace TL.Translator.Web.Areas.Translator.Controllers
{
    public class HomeController : __TranslatorController__
    {
        public bool IsReady { get; set; } = false;

        public IYandexTranslator Translator { get; }

        public List<SelectListItem> AvailableInputCultures { get; } = new List<SelectListItem>();

        public List<ITranslationPair> TranslationPairs { get; set; } = new List<ITranslationPair>();

        public HomeController(IStorage storage, IConfiguration configuration) : base(storage)
        {
            try
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

                IsReady = true;

            }
            catch
            {
                IsReady = false;
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(FillModel(new TranslateViewModel(AvailableInputCultures) { Input = "Hello, World!" }));
        }

        [HttpPost]
        public IActionResult Index(TranslateViewModel model)
        {
            model = FillModel(model);

            return PartialView("_Translate", model);
        }

        [HttpPost]
        public IActionResult Save(TranslateViewModel model)
        {
            model = FillModel(model);

            if (User.Identity.IsAuthenticated)
            {
                Storage.GetRepository<ITranslationRepository>().Add(new Data.Entities.Translations.Translation()
                {
                    AuthorId = Storage.GetRepository<IUserRepository>().GetByUsername(User.Identity.Name).Id,
                    Date = DateTime.Now,
                    InputCulture = model.InputCulture,
                    OutputCulture = model.OutputCulture,
                    InputText = model.Input,
                    OutputText = model.Output
                });
                Storage.Save();
                model.StatusMessage = "Ваш перевод сохранён!";
            }

            return PartialView("_Translate", model);
        }

        private TranslateViewModel FillModel(TranslateViewModel model)
        {
            model.IsReady = IsReady;

            model.AvailableInputCultures = AvailableInputCultures;

            if (string.IsNullOrWhiteSpace(model.Input))
            {
                model.InputCulture = "en";
            }

            if (string.IsNullOrWhiteSpace(model.InputCulture))
            {
                model.InputCulture = IsReady ? Translator?.Detect(model.Input) : "en";
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
                    model.OutputCulture = supportedCulturesForInput.FirstOrDefault()?.ToLanguage ?? "ru";
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

            model.Output = IsReady ? Translator?
                .Translate(request =>
                    request.From(model.InputCulture)
                    .To(model.OutputCulture)
                    .Text(model.Input)
                    .Html()
                ).Text : "Привет, мир!";

            return model;
        }
    }
}
