using Microsoft.AspNetCore.Mvc;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    public class HomeController : __IntegrationsController__
    {
        public IActionResult Index()
        {
            return Redirect("/integrations/telegram");
        }
    }
}
