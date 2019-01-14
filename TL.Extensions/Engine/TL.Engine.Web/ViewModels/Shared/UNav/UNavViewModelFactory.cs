using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class UNavViewModelFactory
    {
        public UNavViewModel Create(IEnumerable<string> roles)
        {
            List<NavItem> navItems = new List<NavItem>();

            roles = roles.ToList();

            foreach (var extensionMetadata in ExtensionManager.GetInstances<BaseMetadataWeb>())
            {
                foreach (var navItem in extensionMetadata.NavItems)
                {
                    var niRoles = navItem.Roles ?? new List<string>();
                    var intersection = niRoles.Intersect(roles);

                    if (intersection.Count() > 0)
                    {
                        navItems.Add(navItem);
                    }
                }
            }

            return new UNavViewModel()
            {
                UNavItems = navItems
                    .OrderBy(ni => ni.Position)
                    .Select(ni => new UNavItemViewModelFactory().Create(ni))
            };
        }
    }
}