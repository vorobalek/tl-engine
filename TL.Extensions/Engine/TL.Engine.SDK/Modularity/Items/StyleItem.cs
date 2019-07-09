namespace TL.Engine.SDK.Modularity.Items
{
    /// <summary>
    /// Ссылка на таблицу стилей.
    /// </summary>
    public class StyleItem
    {
        /// <summary>
        /// URL адрес.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Позиция для упорядочивания в интерфейсе.
        /// </summary>
        public int Position { get; set; }

        public StyleItem(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
