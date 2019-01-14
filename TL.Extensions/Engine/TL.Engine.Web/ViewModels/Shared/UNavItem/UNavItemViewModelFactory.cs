using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class UNavItemViewModelFactory
    {
        public UNavItemViewModel Create(NavItem menuItem)
        {
            return new UNavItemViewModel()
            {
                Url = menuItem.Url,
                Name = menuItem.Name
            };
        }
    }
}