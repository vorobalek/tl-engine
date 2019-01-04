using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class MenuItemViewModelFactory
    {
        public MenuItemViewModel Create(MenuItem menuItem)
        {
            return new MenuItemViewModel()
            {
                Url = menuItem.Url,
                Name = menuItem.Name
            };
        }
    }
}