using ExtCore.Data.Abstractions;
using TL.Api.SDK.Controllers;

namespace TL.Api.Web.Areas.Api.Controllers
{
    public abstract class __ApiHelpController__ : BaseApiHelpController
    {
        public __ApiHelpController__(IStorage storage) : base(storage)
        {
        }
    }
}
