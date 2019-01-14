using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class NavViewModelFactory
    {
        public NavViewModel Create()
        {
            List<NavItem> navItems = new List<NavItem>();

            foreach (var extensionMetadata in ExtensionManager.GetInstances<BaseMetadataWeb>())
            {
                navItems.AddRange(extensionMetadata.NavItems.Where(ni => ni.Roles == null));
            }

            return new NavViewModel()
            {
                NavItems = navItems
                    .OrderBy(ni => ni.Position)
                    .Select(ni => new NavItemViewModelFactory().Create(ni))
            };
        }
    }
}