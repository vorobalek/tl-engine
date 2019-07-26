using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.SDK.ViewComponents
{
    /// <summary>
    /// Абстрактная реализация базового веб-компонента.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ViewComponent" />
    /// <seealso cref="TL.Engine.SDK.ViewComponents.IBaseViewComponent" />
    public abstract class BaseViewComponent : ViewComponent, IBaseViewComponent
    {
    }
}
