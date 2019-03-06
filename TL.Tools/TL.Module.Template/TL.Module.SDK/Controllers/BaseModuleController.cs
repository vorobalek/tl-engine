using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace $safeprojectname$.Controllers
{
    [Area("$saferootprojectname$")]
    public abstract class Base$saferootprojectname$Controller : BaseController
    {
        public Base$saferootprojectname$Controller(IStorage storage) : base(storage)
        {
        }
    }
}
