using Microsoft.AspNetCore.Mvc;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class EditViewModel
    {
        [BindProperty]
        public LinkViewModel InputModel { get; set; }

        public string Message { get; set; }

        public string ReturnUrl { get; set; }

        public EditViewModel()
        {
        }

        public EditViewModel(LinkViewModel model, string message)
        {
            InputModel = model;
            Message = message;
        }
    }
}
