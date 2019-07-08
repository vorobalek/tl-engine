using TL.Linker.Data.Entities.Core;
using TL.Linker.Data.Managers;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class LinkViewModelFactory
    {
        public LinkViewModel Create(ILinkManager linkManager, Link link)
        {
            return new LinkViewModel(
                    id: link.Id,
                    path: linkManager.LinkConvert(link.Identifier),
                    originalPath: link.Url,
                    creationDate: link.CreationDate,
                    modifiedDate: link.ModifiedDate,
                    isDeleted: link.IsDeleted);
        }
    }
}
