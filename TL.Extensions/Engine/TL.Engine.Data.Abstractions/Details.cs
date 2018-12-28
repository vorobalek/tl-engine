using TL.Engine.SDK.Modules;

namespace TL.Engine.Data.Abstractions
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Engine.Data.Abstractions";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
