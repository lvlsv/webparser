using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Core
{
    internal class UrlDispatcher
    {
        private IParserSettings settings;
        private List<AngleSharp.Dom.ILinkImport> links; 

        public UrlDispatcher(IParserSettings settings)
        {
            this.settings = settings;
        }

        public List<ILinkImport> Links { get => links; set => links = value; }
    }
}
