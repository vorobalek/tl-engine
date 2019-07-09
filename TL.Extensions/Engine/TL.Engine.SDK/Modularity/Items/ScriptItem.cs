namespace TL.Engine.SDK.Modularity.Items
{
    /// <summary>
    /// Ссылка на подключение скрипта.
    /// </summary>
    public class ScriptItem
    {
        /// <summary>
        /// URL адрес.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Позиция для упорядочивания в интерфейсе.
        /// </summary>
        public int Position { get; set; }

        public ScriptItem(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
