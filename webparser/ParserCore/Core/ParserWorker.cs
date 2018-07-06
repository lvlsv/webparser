using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        bool isActive;

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;

        public IParser<T> Parser { get => parser; set => parser = value; }
        public IParserSettings ParserSettings { get => parserSettings; set => { parserSettings = value; loader = new HtmlLoader(ValueType); } }
        public bool IsActive { get => isActive; }

        public ParserWorker(IParser<T> parser)
        {
            Parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings settings) : this(parser)
        {
            this.parserSettings = settings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }
        public void Abprt()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();
                var document = await domParser.ParseAsync(source);
                var result = parser.Parse(document);
                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            isActive = false;
        }


    }
}
