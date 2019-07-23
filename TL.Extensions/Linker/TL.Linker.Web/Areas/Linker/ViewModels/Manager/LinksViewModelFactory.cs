using System.Linq;
using TL.Linker.Data.Managers;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class LinksViewModelFactory
    {
        public LinksViewModel Create(ILinkManager linkManager, string orderByProperty, string desc, int page, int per)
        {
            var links = linkManager.GetAll(loadDeleted: true).OrderByDescending(l => l.ModifiedDate).Skip((page - 1) * per).Take(per);
            var linkModels = links.Select(link =>
            {
                return new LinkViewModelFactory().Create(linkManager, link);
            });
            var type = typeof(LinkViewModel);
            var property = type.GetProperty(orderByProperty) ?? type.GetProperty(nameof(LinkViewModel.ModifiedDate));
            if (bool.TryParse(desc, out bool descIsEnable) && descIsEnable)
            {
                return new LinksViewModel(linkModels.OrderByDescending(e => property.GetValue(e, null)), orderByProperty, true);
            }
            else
            {
                return new LinksViewModel(linkModels.OrderBy(e => property.GetValue(e, null)), orderByProperty, false);
            }
        }
    }
}
