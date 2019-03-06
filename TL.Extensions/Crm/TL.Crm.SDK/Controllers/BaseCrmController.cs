using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Crm.SDK.Controllers
{
    [Area("Crm")]
    [Authorize(Roles = "sa")]
    public abstract class BaseCrmController : BaseController
    {
        public BaseCrmController(IStorage storage) : base(storage)
        {
        }
    }
}
