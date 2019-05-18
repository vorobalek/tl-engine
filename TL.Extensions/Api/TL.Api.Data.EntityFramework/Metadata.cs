using System;
using TL.Engine.SDK.Modularity;

namespace TL.Api.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Api.Data.EntityFramework";

        public override string Owner => "TL.Api";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";

        protected override Version Version => new Version(1, 1, 0, 2);
    }
}
