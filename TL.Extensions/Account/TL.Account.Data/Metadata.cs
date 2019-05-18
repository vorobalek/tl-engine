using System;
using TL.Engine.SDK.Modularity;

namespace TL.Account.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Account.Data";

        public override string Owner => "TL.Account";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        protected override Version Version => new Version(1, 1, 0, 2);
    }
}
