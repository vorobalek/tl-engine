using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class MenuViewModelFactory
    {
        public MenuViewModel Create()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (var extensionMetadata in ExtensionManager.GetInstances<MetadataBaseWeb>())
            {
                menuItems.AddRange(extensionMetadata.MenuItems);
            }

            return new MenuViewModel()
            {
                MenuItems = menuItems
                    .OrderBy(mi => mi.Position)
                    .Select(mi => new MenuItemViewModelFactory().Create(mi))
            };
        }
    }
}