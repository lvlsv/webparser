using AngleSharp.Dom.Html;
using ParserCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Ciitilink
{
    public class CitilinkParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("link_gtm-js link_pageevents-js ddl_product_link"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
