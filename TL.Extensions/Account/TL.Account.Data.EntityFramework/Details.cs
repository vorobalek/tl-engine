using TL.Engine.SDK.Modules;

namespace TL.Account.Data.EntityFramework
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account.Data.EntityFramework";

        public override string Owner => "TL.Account";

        public override string Icon => "/Areas/Account/Styles/images/package.png";

        public override string Description =>
            $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
