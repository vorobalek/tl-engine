using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Crm.Web.Areas.Crm.Controllers
{
    [Area("Crm")]
    public abstract class __CrmController__ : BaseController
    {
        public __CrmController__(IStorage storage) : base(storage)
        {
        }
    }
}
