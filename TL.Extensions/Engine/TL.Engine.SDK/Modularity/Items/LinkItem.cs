using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modularity.Items
{
    /// <summary>
    /// Веб-ссылка.
    /// </summary>
    public class LinkItem
    {
        private string _url;

        /// <summary>
        /// URL адрес.
        /// </summary>
        public string Url
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_url)) return _url;

                var item = Items.FirstOrDefault(i => i.Url != "#");
                if (item != null) return item.Url;

                return "#";
            }

            set => _url = value;
        }

        /// <summary>
        /// Псевдоним, отображаемый в веб.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дочерние элементы <see cref="LinkItem"/>
        /// </summary>
        public IEnumerable<LinkItem> Items { get; set; }

        /// <summary>
        /// Позиция для упорядочивания в интерфейсе.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Подсказка для ссылки.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Роли, для которых разрешено отображать ссылку.
        /// </summary>
        public IEnumerable<string> Roles { get; set; }

        public LinkItem(string url, string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
            : this(url, name, null, position, roles, items)
        {
        }

        public LinkItem(string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
            : this(null, name, position, roles, items)
        {
        }

        public LinkItem(string url, string name, string description, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
        {
            Url = url;
            Name = name;
            Description = description;
            Position = position;
            Roles = roles;
            Items = items ?? new List<LinkItem>();
        }
    }
}
