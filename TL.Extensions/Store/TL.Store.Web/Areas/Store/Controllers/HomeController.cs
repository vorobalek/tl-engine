using Microsoft.AspNetCore.Mvc;
using TL.Store.Web.Areas.Store.ViewModels.Home;

namespace TL.Store.Web.Areas.Store.Controllers
{
    public class HomeController : __StoreController__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
