using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Translator.Web.Areas.Translator.Controllers
{
    [Area("Translator")]
    public abstract class __TranslatorController__ : __BaseController__
    {
        public __TranslatorController__(IStorage storage) : base(storage)
        {
        }
    }
}
