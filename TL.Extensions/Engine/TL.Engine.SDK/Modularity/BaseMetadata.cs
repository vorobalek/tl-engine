using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TL.Engine.SDK.Modularity
{
    /// <summary>
    /// Метадата модуля
    /// </summary>
    public abstract class BaseMetadata
    {
        /// <summary>
        /// Минимальная версия модуля. Устанавливается только в абстрактном классе <see cref="BaseMetadata"/>.
        /// </summary>
        private Version MinimalVersion => new Version(1, 1, 0, 6);

        /// <summary>
        /// Имя текущей сборки модуля.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Описание текущей сборки модуля.
        /// </summary>
        public virtual string Description => $"Модуль системы TL Engine. {Name}.dll";

        /// <summary>
        /// Автор(-ы) текущей сборки модуля.
        /// </summary>
        public virtual string Authors => "";

        /// <summary>
        /// Имя основной сборки модуля.
        /// </summary>
        public virtual string Owner => "";

        /// <summary>
        /// Зависимые сборки <see cref="BaseMetadata"/>.
        /// </summary>
        public virtual IEnumerable<BaseMetadata> ReferencesModules { get; set; } = new List<BaseMetadata>();

        /// <summary>
        /// Зависимые сборки <see cref="Assembly"/>.
        /// </summary>
        public virtual IEnumerable<Assembly> ReferencesAssemblies { get; set; } = new List<Assembly>();

        /// <summary>
        /// Сборки подмодулей.
        /// </summary>
        public virtual IEnumerable<BaseMetadata> SubModules =>
            ExtensionManager.GetInstances<BaseMetadata>()
                .Where(m => m.Owner == Name)
                .OrderBy(sm => sm.Name);

        /// <summary>
        /// Получить версию SDK модуля.
        /// </summary>
        /// <returns></returns>
        public Version GetVersionSDK()
        {
            int compareValue = Version.CompareTo(MinimalVersion);
            if (compareValue < 0)
            {
                return MinimalVersion;
            }
            else
            {
                return Version;
            }
        }

        /// <summary>
        /// Получить версию модуля.
        /// </summary>
        /// <returns>Актуальная версия модуля.</returns>
        public Version GetVersion()
        {
            return Version;
        }

        /// <summary>
        /// Гарантированная версия модуля.
        /// </summary>
        protected virtual Version Version => new Version(0, 0, 0, 0);
    }
}
