using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class StyleViewModelFactory
    {
        public StyleViewModel Create(Style style)
        {
            return new StyleViewModel()
            {
                Url = style.Url
            };
        }
    }
}