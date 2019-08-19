using System.Linq;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class LinkViewModelFactory
    {
        public LinkViewModel Create(LinkItem linkItem)
        {
            return new LinkViewModel()
            {
                Url = linkItem.Url,
                Name = linkItem.Name,
                Description = linkItem.Description,
                Items = linkItem.Items?.Select(li => new LinkViewModelFactory().Create(li)),
                IsAvailable = linkItem.IsAvailable
            };
        }
    }
}