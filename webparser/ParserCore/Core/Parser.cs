using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;
using ParserCore.Helpers;

namespace ParserCore.Core
{
    class Parser : IParser
    {
        public string[] Parse(IHtmlDocument document, string elementTag, string elementClasses, bool downloadFiles = false)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll(elementTag).Where(item => item.ClassName != null && item.ClassName.Contains(elementClasses));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
