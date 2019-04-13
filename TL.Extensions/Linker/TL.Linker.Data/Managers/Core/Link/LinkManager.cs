using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Managers
{
    public class LinkManager : EntityComparableStoredManager<Link, int>, ILinkManager
    {
        public LinkManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        [PublicApi]
        public string GetLinkUrl(string url)
        {
            var link = Get(LinkParse(url));
            if (link == null)
            {
                throw new ArgumentException($"Такого адреса не существует", nameof(url));
            }
            return link.Url;
        }

        public Link Create(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException($"Url не может быть пустым!", nameof(url));
            }

            var link = Get(e => e.Url == url);
            if (link == null)
            {
                return Create(new Link()
                {
                    Url = url
                });
            }
            else
            {
                return link;
            }
        }

        static string Mask { get; } = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        [PublicApi]
        public string LinkConvert(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Число не может быть меньше 1");
            }

            if (number > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Число не может быть больше 2147483647");
            }

            string ans = "";

            while (number > 0)
            {
                var code = number % Mask.Length;
                ans += Mask[code];
                number /= Mask.Length;
            }
            return new string (ans.ToCharArray().Reverse().ToArray());
        }

        [PublicApi]
        public int LinkParse(string code)
        {
            int ans = 0;
            foreach (var c in code)
            {
                int i = 0;
                for (; i < Mask.Length; ++i)
                {
                    if (Mask[i] == c)
                    {
                        break;
                    }
                }

                if (i == Mask.Length)
                {
                    throw new ArgumentException($"Входная строка имела неверный формат!", nameof(code));
                }

                ans = ans * Mask.Length + i;
            }
            return ans;
        }
    }
}
