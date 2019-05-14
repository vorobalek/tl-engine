using Microsoft.AspNetCore.Mvc;
using $safeprojectname$.Areas.$saferootprojectname$.ViewModels.Home;

namespace $safeprojectname$.Areas.$saferootprojectname$.Controllers
{
    public class HomeController : __$saferootprojectname$Controller__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
