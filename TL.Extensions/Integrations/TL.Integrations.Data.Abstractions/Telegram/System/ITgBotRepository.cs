using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Abstractions.Telegram.System
{
    public interface ITgBotRepository : IRepository
    {
        void Add(TgBot bot);

        void Update(TgBot bot);

        void Remove(TgBot bot);

        void Remove(Guid guid);

        TgBot GetById(Guid id);

        IEnumerable<TgBot> GetAll();

        IEnumerable<TgBot> GetByUsername(string username);

        TgBot GetByTokenAndType(string token, string type);
    }
}
