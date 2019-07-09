using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.SDK.Extensions
{
    /// <summary>
    /// Расширения типа <see cref="LinkItem"/>.
    /// </summary>
    public static class LinkItemExtensions
    {
        /// <summary>
        /// Выбрать из коллекции <see cref="LinkItem"/> дозволенные для заданной коллекции ролей.
        /// </summary>
        /// <param name="linkItems">Коллекция <see cref="LinkItem"/>.</param>
        /// <param name="roles">Коллекция ролей.</param>
        /// <returns></returns>
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
