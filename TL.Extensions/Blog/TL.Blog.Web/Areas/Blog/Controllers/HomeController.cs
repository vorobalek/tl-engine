using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Blog.Web.Areas.Blog.ViewModels.Home;

namespace TL.Blog.Web.Areas.Blog.Controllers
{
    public class HomeController : __BlogController__
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
