using TL.Linker.Data.Entities.Core;
using TL.Linker.Data.Managers;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class EditViewModelFactory
    {
        public EditViewModel Create(ILinkManager linkManager, Link link, string message = null)
        {
            return new EditViewModel(linkManager, link, message);
        }
    }
}
