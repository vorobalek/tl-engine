using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class MenuViewModelFactory
    {
        public MenuViewModel Create(IEnumerable<string> roles)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            roles = roles.ToList();

            foreach (var extensionMetadata in ExtensionManager.GetInstances<BaseMetadataWeb>())
            {
                foreach (var menuItem in extensionMetadata.MenuItems)
                {
                    if (menuItem.Roles == null)
                    {
                        menuItems.Add(menuItem);
                        continue;
                    }

                    var miRoles = menuItem.Roles ?? new List<string>();
                    var intersection = miRoles.Intersect(roles);

                    if (intersection.Count() > 0)
                    {
                        menuItems.Add(menuItem);
                    }
                }
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