using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.SDK.Extensions
{
    public static class LinkItemExtensions
    {
        public static IEnumerable<LinkItem> GetValidLinkItems(this IEnumerable<LinkItem> linkItems, IEnumerable<string> roles)
        {
            var validItems = new List<LinkItem>();

            if (linkItems != null)
            {
                foreach (var linkItem in linkItems)
                {
                    if (linkItem.Roles != null)
                    {
                        var liRoles = linkItem.Roles ?? new List<string>();
                        var intersection = liRoles.Intersect(roles);

                        if (intersection.Count() > 0)
                        {
                            linkItem.Items = linkItem.Items.GetValidLinkItems(roles);
                            validItems.Add(linkItem);
                        }
                    }
                    else
                    {
                        linkItem.Items = linkItem.Items.GetValidLinkItems(roles);
                        validItems.Add(linkItem);
                    }
                }
            }

            return validItems;
        }
    }
}
