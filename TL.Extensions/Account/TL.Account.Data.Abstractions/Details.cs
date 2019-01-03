using TL.Engine.SDK.Modules;

namespace TL.Account.Data.Abstractions
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account.Data.Abstractions";

        public override string Owner => "TL.Account";

        public override string Icon => "/Areas/Account/Styles/images/package.png";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
