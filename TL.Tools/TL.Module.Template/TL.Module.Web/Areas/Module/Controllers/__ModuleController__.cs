using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace $safeprojectname$.Areas.$saferootprojectname$.Controllers
{
    [Area("$saferootprojectname$")]
    public abstract class __$saferootprojectname$Controller__ : __BaseController__
    {
        public __$saferootprojectname$Controller__(IStorage storage) : base(storage)
        {
        }
    }
}
