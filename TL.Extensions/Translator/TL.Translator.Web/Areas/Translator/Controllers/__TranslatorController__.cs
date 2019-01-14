using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Translator.Web.Areas.Translator.Controllers
{
    [Area("Translator")]
    public abstract class __TranslatorController__ : BaseController
    {
        public __TranslatorController__(IStorage storage) : base(storage)
        {
        }
    }
}
