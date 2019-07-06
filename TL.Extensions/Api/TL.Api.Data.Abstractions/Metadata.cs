using System;
using TL.Engine.SDK.Modularity;

namespace TL.Api.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Api.Data.Abstractions";

        public override string Owner => "TL.Api";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        protected override Version Version => new Version(1, 1, 0, 5);
    }
}
