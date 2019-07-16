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
        public ManagerController(ILinkManager linkManager)
        {
            LinkManager = linkManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("linker/manager/edit/{id}")]
        public IActionResult Edit(Guid id)
        {
            if (LinkManager.Get(id, loadDeleted: true) is Link link)
            {
                var model = new EditViewModelFactory().Create(LinkManager, link);
                model.ReturnUrl = "/linker/manager/"; // Request.Headers["Referer"].ToString();
                return View(model);
            }
            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var link = LinkManager.Get(model.Input.Id, loadDeleted: true);

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
        public IActionResult GetAll(string orderBy, string desc)
        {
            return PartialView("_Links", new IndexViewModelFactory().Create(LinkManager, orderBy, desc));
        }

        [HttpPost]
        public IActionResult Restore(IndexViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.Get(guid, loadDeleted: true);
                if (token != null)
                {
                    token.IsDeleted = false;
                    LinkManager.Update(token);
                }
            }

            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Remove(IndexViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.Get(guid, loadDeleted: true);
                if (token != null)
                {
                    LinkManager.Remove(token);
                }
            }
            return Redirect("/linker/manager/");
        }

        [HttpPost]
        public IActionResult Delete(IndexViewModel model)
        {
            var guid = model.BindModel.LinkId;
            {
                var token = LinkManager.Get(guid, loadDeleted: true);
                if (token != null)
                {
                    LinkManager.Delete(token);
                }
            }
            return Redirect("/linker/manager/");
        }
    }
}
