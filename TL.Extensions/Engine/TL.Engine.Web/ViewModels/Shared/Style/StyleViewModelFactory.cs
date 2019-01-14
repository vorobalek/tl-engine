using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class StyleViewModelFactory
    {
        public StyleViewModel Create(StyleItem style)
        {
            return new StyleViewModel()
            {
                Url = style.Url
            };
        }
    }
}