using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Crm.Web.Areas.Crm.Controllers
{
    [Area("Crm")]
    [Authorize(Roles = "sa")]
    public abstract class __CrmController__ : BaseController
    {
        public __CrmController__(IStorage storage) : base(storage)
        {
        }
    }
}
