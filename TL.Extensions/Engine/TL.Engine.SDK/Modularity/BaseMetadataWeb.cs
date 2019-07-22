using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.SDK.Modularity
{
    /// <summary>
    /// Метадата веб-сборки модуля.
    /// </summary>
    /// <seealso cref="TL.Engine.SDK.Modularity.BaseMetadata" />
    public abstract class BaseMetadataWeb : BaseMetadata
    {
        /// <summary>
        /// Элементы навигационной панели.
        /// </summary>
        public abstract IEnumerable<LinkItem> NavbarItems { get; }

        /// <summary>
        /// Ссылки на подключение скриптов.
        /// </summary>
        public abstract IEnumerable<ScriptItem> ScriptItems { get; }

        /// <summary>
        /// Элементы боковой панели.
        /// </summary>
        public abstract IEnumerable<LinkItem> SidebarItems { get; }

        /// <summary>
        /// Элементы панели администрирования.
        /// </summary>
        protected virtual IEnumerable<LinkItem> AdminItems { get; } = new LinkItem[0];

        protected IEnumerable<LinkItem> GetAdminItems() =>
            ExtensionManager
            .GetInstances<BaseMetadataWeb>(useCaching: true)
            .Select(m => m.AdminItems
                .OrderBy(it => it.Position)
                .Select(it => new LinkItem(it.Url, it.Name, $"{it.Description} ({m.Owner})", it.Position, it.Roles, it.Items)))
            .SelectMany(it => it);

        /// <summary>
        /// Ссылки на таблицы стилей.
        /// </summary>
        public abstract IEnumerable<StyleItem> StyleItems { get; }

        /// <summary>
        /// Элементы выпадающего меню пользователя навигационной панели.
        /// </summary>
        public abstract IEnumerable<LinkItem> UserNavbarItems { get; }
    }
}
