using ExtCore.Data.Abstractions;
using TL.Api.SDK.Controllers;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    public abstract class __ApiHelpController__ : BaseApiHelpController
    {
        public __ApiHelpController__(IStorage storage) : base(storage)
        {
        }
    }
}
