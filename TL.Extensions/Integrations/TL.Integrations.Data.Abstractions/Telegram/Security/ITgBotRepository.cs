using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgBotRepository : IRepository
    {
        void Add(TgBot bot);

        void Update(TgBot bot);

        IEnumerable<TgBot> GetAll();

        TgBot GetById(Guid id);

        IEnumerable<TgBot> GetByUsername(string username);
    }
}
