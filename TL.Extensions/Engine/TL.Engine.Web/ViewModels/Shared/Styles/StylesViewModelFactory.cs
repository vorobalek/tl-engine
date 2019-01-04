using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class StylesViewModelFactory
    {
        public StylesViewModel Create()
        {
            List<Style> styles = new List<Style>();

            foreach (MetadataBaseWeb extensionMetadata in ExtensionManager.GetInstances<MetadataBaseWeb>())
            {
                styles.AddRange(extensionMetadata.Styles);
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