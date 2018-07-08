using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Core
{
    public interface IParserSettings
    {
        /// <summary>
        /// Основной адрес сайта (жертвы) - например http://www.yandex.ru
        /// </summary>
        string BaseUrl { get; set; }

        /// <summary>
        /// Префикс может быть дополнением каталога в адресе - выделяется в соответствии с маршрутизацией
        /// </summary>
        string  Prefix { get; set; }

        string MenuItemTagName { get; set; }
        string MenuItemClassesName { get; set; }

        string SubmenuPrefix { get; set; }
        string SubmenuItemTagName { get; set; }
        string SubmenuItemClassesName { get; set; }

        string ProductItemTagName { get; set; }
        string ProductItemClassesName { get; set; }

        string ProductPropertiesItemName { get; set; }
        string ProductPropertiesValue { get; set; }
        
    }
}
