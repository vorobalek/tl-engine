using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class NavItemViewModelFactory
    {
        public NavItemViewModel Create(NavItem menuItem)
        {
            return new NavItemViewModel()
            {
                Url = menuItem.Url,
                Name = menuItem.Name
            };
        }
    }
}