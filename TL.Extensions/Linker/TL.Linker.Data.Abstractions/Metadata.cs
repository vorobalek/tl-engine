using System;
using TL.Engine.SDK.Modularity;

namespace TL.Linker.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Linker.Data.Abstractions";

        public override string Owner => "TL.Linker";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        protected override Version Version => new Version(1, 1, 0, 4);
    }
}
