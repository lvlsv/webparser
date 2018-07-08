using AngleSharp.Dom.Html;
using System.Collections.Generic;

namespace ParserCore.Core
{
    /// <summary>
    /// Объявляет сигнатуры методов необходимых для парсинга различных элементов HTML документа.
    /// </summary>
    /// <typeparam name="T"> Любой тип удовлетворяющий в качестве возвращаемого значения.</typeparam>
    public interface IParser
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="elementTag"></param>
        /// <param name="elementClasses"></param>
        /// <param name="downloadFiles"></param>
        /// <returns></returns>
        string[] Parse(IHtmlDocument document, string elementTag, string elementClasses, bool downloadFiles = false);        
    }
}
