using TL.Engine.SDK.Modules;

namespace TL.Account.Data.Entities
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account.Data.Entities";

        public override string Owner => "TL.Account";

        public override string Description =>
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
