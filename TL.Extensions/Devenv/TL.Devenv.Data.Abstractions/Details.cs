using TL.Engine.SDK.Modules;

namespace TL.Devenv.Data.Abstractions
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv.Data.Abstractions";

        public override string Owner => "TL.Devenv";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
