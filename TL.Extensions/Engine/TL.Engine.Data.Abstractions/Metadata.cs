using System;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "Core.Data.Abstractions";

        public override string Owner => "Core";

        public override string Description => 
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
