using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;
using System.Linq;
using TL.Linker.Data.Managers;
using TL.Linker.Web.Areas.Linker.ViewModels.Get;

namespace TL.Linker.Web.Areas.Linker.Controllers
{
    public class GetController : __LinkerController__
    {
        ILinkManager LinkManager { get; set; }

        public GetController(ILinkManager linkManager, IStorage storage) : base(storage)
        {
            LinkManager = linkManager;
        }

        public IActionResult Index()
        {
            return View("Index", new IndexViewModelFactory().Create());
        }

        [HttpGet]
        public IActionResult FromUrl([FromQuery]string url)
        {
            return Index(url);
        }

        [HttpPost]
        public IActionResult Index(string url)
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(url))
            {
                ModelState.AddModelError("url", "Url указан неверно!");
                return View("Index");
            }

            if (url.Length > 1000)
            {
                ModelState.AddModelError("url", "Этот URL слишком длинный даже для нас");
                return View("Index");
            }

            var parts = url.Split("://");
            if (parts[parts.Length > 1 ? 1 : 0].StartsWith(HttpContext.Request.Host.Value))
            {
                ModelState.AddModelError("url", "Мы не можем сократить эту ссылку");
                return View("Index");
            }

            var link = LinkManager.Create(url);
            return View("Link", $"https://{HttpContext.Request.Host.Value}/lnk/{LinkManager.LinkConvert(link.Identifier)}");
        }

        [HttpGet("lnk/{url}")]
        public IActionResult UseLink(string url)
        {
            var link = LinkManager.Get(LinkManager.LinkParse(url));
            if (link == null)
            {
                return View("Index", new IndexViewModelFactory().Create());
            }
            else
            {
                var prefixs = new[]
                {
                    "ftp",
                    "http",
                    "https",
                };

                var parts = link.Url.Split("://");

                if (parts.Length > 1 && prefixs.Contains(parts[0]))
                {
                    return Redirect(link.Url);
                }
                else
                {
                    return Redirect($"http://{link.Url}");
                }

            }
        }
    }
}
