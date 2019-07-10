using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Managers
{
    internal class LinkManager : EntityComparableStoredManager<Link, Guid>, ILinkManager
    {
        public const string NameOfMaskVariable = "LinkerMask";

        public const string NameOfMaxLengthVariable = "LinkerMaxLength";

        public IStringVariableManager StringVariableManager { get; set; }

        public LinkManager(IStringVariableManager stringVariableManager, IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
            StringVariableManager = stringVariableManager;
        }

        public Link Get(ulong id)
        {
            return Get(e => e.Identifier == id);
        }

        public string GetLinkUrl(string link)
        {
            return Get(LinkParse(link))?.Url;
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
                var random = new Random();

                ulong identifier = 0;
                if (int.TryParse(StringVariableManager.Get(NameOfMaxLengthVariable)?.Value, out int length))
                {
                    var mask = StringVariableManager.Get(NameOfMaskVariable)?.Value;
                    for (int i = 0; i < length; ++i)
                    {
                        int digit = random.Next(mask.Length);
                        identifier = identifier * (ulong)mask.Length + (ulong)digit;
                    }
                }

                return Create(new Link()
                {
                    Identifier = identifier,
                    Url = url
                });
            }
            else
            {
                return link;
            }
        }

        public string LinkConvert(ulong number)
        {
            return LinkConvert(number, StringVariableManager.Get(NameOfMaskVariable)?.Value);
        }

        private string LinkConvert(ulong number, string mask)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Число не может быть меньше 0");
            }

            if (number > ulong.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Число не может быть больше {ulong.MaxValue}");
            }

            string ans = "";

            while (number > 0)
            {
                var code = number % (ulong)mask.Length;
                ans += mask[(int)code];
                number /= (ulong)mask.Length;
            }
            return new string(ans.ToCharArray().Reverse().ToArray());
        }

        public ulong LinkParse(string code)
        {
            return LinkParse(code, StringVariableManager.Get(NameOfMaskVariable)?.Value);
        }

        private ulong LinkParse(string code, string mask)
        {
            ulong ans = 0;
            foreach (var c in code)
            {
                int i = 0;
                for (; i < mask.Length; ++i)
                {
                    if (mask[i] == c)
                    {
                        break;
                    }
                }

                if (i == mask.Length)
                {
                    throw new ArgumentException($"Входная строка имела неверный формат!", nameof(code));
                }

                ans = ans * (ulong)mask.Length + (ulong)i;
            }
            return ans;
        }
    }
}
