using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using $safeprojectname$.Areas.$saferootprojectname$.ViewModels.Home;

namespace $safeprojectname$.Areas.$saferootprojectname$.Controllers
{
    public class HomeController : __$saferootprojectname$Controller__
    {
        public HomeController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
