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
        public CitilinkSettings(int startPoint, int endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public string BaseUrl { get; set; } = "https://www.citilink.ru/catalog/computers_and_notebooks/parts/videocards/";
        public string Prefix { get; set; } = "?available=1&status=55395790&p={CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
