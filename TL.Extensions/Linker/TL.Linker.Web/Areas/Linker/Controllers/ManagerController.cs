using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Linker.Data.Entities.Core;
using TL.Linker.Data.Managers;
using TL.Linker.Web.Areas.Linker.ViewModels.Manager;

namespace TL.Linker.Web.Areas.Linker.Controllers
{
    [Authorize(Roles = "sa")]
    public class ManagerController : __LinkerController__
    {
        ILinkManager LinkManager { get; }
        public ManagerController(ILinkManager linkManager, IStorage storage)
        {
            LinkManager = linkManager;
        }

        public IActionResult Index(string page, string per)
        {
            var count = LinkManager.Count();
            if (int.TryParse(page, out int int_page) && int.TryParse(per, out int int_perPage))
            {
                return View(new IndexViewModelFactory().Create(count, int_page, int_perPage));
            }
            return View(new IndexViewModelFactory().Create(count, 1, 10));
        }

        [HttpGet("linker/manager/edit/{id}")]
        public IActionResult Edit(Guid id)
        {
            if (LinkManager.GetByKey(id) is Link link)
            {
                var model = new EditViewModelFactory().Create(LinkManager, link);
                model.ReturnUrl = Url.Content(Request.Headers["Referer"].ToString());
                return View(model);
            }
            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var link = LinkManager.GetByKey(model.Input.Id);

                link.Identifier = LinkManager.LinkParse(model.Input.Path);
                link.Url = model.Input.OriginalPath;
                link.LifetimeSeconds = (int)Math.Min((long)((DateTime.Now - link.CreationDate).TotalSeconds + model.Input.LifetimeSeconds), int.MaxValue);

                LinkManager.Update(link);
                var newModel = new EditViewModelFactory().Create(LinkManager, link, "Линк успешно обновлён!");
                newModel.ReturnUrl = model.ReturnUrl;
                return View(newModel);
            }
            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult GetAll(string orderBy, string desc, int page, int per)
        {
            return PartialView("_Links", new LinksViewModelFactory().Create(LinkManager, orderBy, desc, page, per));
        }

        [HttpPost]
        public IActionResult Restore(LinksViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.GetByKey(guid);
                if (token != null)
                {
                    token.IsDeleted = false;
                    LinkManager.Update(token);
                }
            }

            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Remove(LinksViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.GetByKey(guid);
                if (token != null)
                {
                    LinkManager.Remove(token);
                }
            }
            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Delete(LinksViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.GetByKey(guid);
                if (token != null)
                {
                    LinkManager.Delete(token);
                }
            }
            return Redirect("/linker/manager/");
        }
    }
}
