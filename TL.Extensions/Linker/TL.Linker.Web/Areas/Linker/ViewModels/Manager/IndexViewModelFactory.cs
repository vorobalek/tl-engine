using System.Linq;
using TL.Linker.Data.Managers;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(ILinkManager linkManager, string orderByProperty, string desc)
        {
            var links = linkManager.GetAll(loadDeleted: true);
            var linkModels = links.Select(link =>
            {
                return new LinkViewModelFactory().Create(linkManager, link);
            });
            var type = typeof(LinkViewModel);
            var property = type.GetProperty(orderByProperty) ?? type.GetProperty(nameof(LinkViewModel.ModifiedDate));
            if (bool.TryParse(desc, out bool descIsEnable) && descIsEnable)
            {
                return new IndexViewModel(linkModels.OrderByDescending(e => property.GetValue(e, null)), orderByProperty, true);
            }
            else
            {
                return new IndexViewModel(linkModels.OrderBy(e => property.GetValue(e, null)), orderByProperty, false);
            }
        }
    }
}
