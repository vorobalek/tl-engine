using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Api.Web.Areas.Api.Controllers
{
    [Area("ApiHelp")]
    public abstract class __ApiHelpController__ : BaseController
    {
        public __ApiHelpController__(IStorage storage) : base(storage)
        {
        }
    }
}
