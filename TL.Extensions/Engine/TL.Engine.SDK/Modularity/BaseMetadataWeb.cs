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

        public IEnumerable<LinkItem> GetAdminItems() =>
            AdminItems.OrderBy(it => it.Position);

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
