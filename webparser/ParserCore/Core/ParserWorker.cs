using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;

namespace ParserCore.Core
{
    /// <summary>
    /// Класс включает в себя подготовительную работу с рееьд
    /// </summary>
    /// <typeparam name="T"> Предпочтительный тип для вывода </typeparam>
    public class ParserWorker<T> where T : class
    {
        private bool isActive;
        private IParser parser;
        private IParserSettings parserSettings;
        private HtmlLoader loader;
        private UrlDispatcher dispatcher;        

        public ParserWorker(IParserSettings settings)
        {
            loader = new HtmlLoader();
            parser = new Parser();
            ParserSettings = settings;
            dispatcher = new UrlDispatcher(settings);
        }

        public ParserWorker()
        {
        }

        public event Action<object> OnCompleted;

        public event Action<object, string[]> OnNewData;
        public bool IsActive { get => isActive; }

        public IParserSettings ParserSettings
        {
            get => parserSettings;

            set
            {
                parserSettings = value;
            }
        }
        public void Abort()
        {
            isActive = false;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }
        //private async void Worker()
        //{
        //    for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
        //    {
        //        if (!isActive)
        //        {
        //            OnCompleted?.Invoke(this);
        //            return;
        //        }
        //        var source = await loader.GetSourceByUrl();
        //        var domParser = new HtmlParser();
        //        var document = await domParser.ParseAsync(source);
        //        var result = parser.Parse(document);
        //        OnNewData?.Invoke(this, result);
        //    }
        //    OnCompleted?.Invoke(this);
        //    isActive = false;
        //}

        private async void Worker()
        {            
            if (!isActive)
            {
                OnCompleted?.Invoke(this);
                return;
            }
            var source = await loader.GetSourceByUrl(parserSettings.BaseUrl);
            var domParser = new HtmlParser();
            var document = await domParser.ParseAsync(source);
            var result = parser.Parse(document, parserSettings.MenuItemTagName, parserSettings.MenuItemClassesName);
            OnNewData?.Invoke(this, result);
           
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}