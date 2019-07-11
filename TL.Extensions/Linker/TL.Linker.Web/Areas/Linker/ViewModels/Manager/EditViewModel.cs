using Microsoft.AspNetCore.Mvc;
using System;
using TL.Linker.Data.Entities.Core;
using TL.Linker.Data.Managers;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class EditViewModel
    {
        public class InputModel
        {
            public Guid Id { get; set; }
            public string Path { get; set; }
            public string OriginalPath { get; set; }
            public int LifetimeSeconds { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string Message { get; set; }

        public string ReturnUrl { get; set; }

        public EditViewModel()
        {
        }

        public EditViewModel(ILinkManager linkManager, Link link, string message)
        {
            Input = new InputModel()
            {
                Id = link.Id,
                Path = linkManager.LinkConvert(link.Identifier),
                OriginalPath = link.Url,
                LifetimeSeconds = link.LifetimeSeconds - (int)(DateTime.Now - link.CreationDate).TotalSeconds,
            };
            Message = message;
        }
    }
}
