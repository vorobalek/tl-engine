using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class StylesViewModelFactory
    {
        public StylesViewModel Create(IActivatorService activator)
        {
            List<StyleItem> styles = new List<StyleItem>();

            foreach (var extensionMetadata in activator.GetInstances<BaseMetadataWeb>(useCaching: true))
            {
                styles.AddRange(extensionMetadata.StyleItems);
            }

            return new StylesViewModel()
            {
                Styles = styles
                    .OrderBy(ss => ss.Position)
                    .Select(ss => new StyleViewModelFactory().Create(ss))
            };
        }
    }
}