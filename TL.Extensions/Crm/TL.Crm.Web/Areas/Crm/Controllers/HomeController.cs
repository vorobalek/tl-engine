using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Crm.Web.Areas.Crm.ViewModels.Home;

namespace TL.Crm.Web.Areas.Crm.Controllers
{
    public class HomeController : __CrmController__
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
