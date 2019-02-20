using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TL.Engine.SDK.Entities;
using TL.Integrations.Data.Entities.Telegram.Relationships;

namespace TL.Integrations.Data.Entities.Telegram.System
{
    /// <summary>
    /// Состояние бота
    /// </summary>
    public enum TgBotState
    {
        /// <summary>
        /// Неизвестно
        /// </summary>
        [Display(Name = "Неизвестно")]
        None,
        
        /// <summary>
        /// Остановлен
        /// </summary>
        [Display(Name = "Остановлен")]
        Stop,
        
        /// <summary>
        /// Запуск
        /// </summary>
        [Display(Name = "Запуск")]
        Start,

        /// <summary>
        /// В работе
        /// </summary>
        [Display(Name = "В работе")]
        Run,

        /// <summary>
        /// Сон
        /// </summary>
        [Display(Name = "Сон")]
        Sleep,

        /// <summary>
        /// Перезапуск
        /// </summary>
        [Display(Name = "Перезапуск")]
        Restart,

        /// <summary>
        /// Приостановлен
        /// </summary>
        [Display(Name = "Приостановлен")]
        Pause
    }

    public class TgBot : EntityComparableStored<Guid>
    {
        public string Token { get; set; }

        public string Username { get; set; }

        public string NativeName { get; set; }

        public string TypeName { get; set; }

        public bool SkipUpdates { get; set; }

        public bool AutoStart { get; set; }

        public bool IsRelevant { get; set; }

        public DateTime? LastStartDate { get; set; }

        public TgBotState State { get; set; } = TgBotState.None;

        public virtual IEnumerable<TgConnection> Connections { get; set; }

        public TgBot() : base()
        {
            Connections = new HashSet<TgConnection>();
        }
    }
}
