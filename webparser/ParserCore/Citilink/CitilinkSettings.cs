using ParserCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Ciitilink
{
    public class CitilinkSettings : IParserSettings
    {        
        public string BaseUrl { get; set; } = "https://www.citilink.ru";
        public string Prefix { get; set; } = "/catalog/";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public string MenuItemTagName { get; set; } = "a";
        public string MenuItemClassesName { get; set; } = "link_side-menu";
        public string SubmenuPrefix { get; set; }
        public string SubmenuItemTagName { get; set; } = "a";
        public string SubmenuItemClassesName { get; set; } = "subcategory-list-item__link link_side-menu-level2";
        public string ProductItemTagName { get; set; }
        public string ProductItemClassesName { get; set; }
        public string ProductPropertiesItemName { get; set; }
        public string ProductPropertiesValue { get; set; }
    }
}
