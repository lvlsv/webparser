using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserCore.Ciitilink;
using ParserCore.Core;

namespace ParserCore.Test
{
    [TestClass]
    public class CitilinkParserTest
    {
        List<string> list = new List<string>();
        bool isCompleted;

        [TestMethod]
        public void Parse_InputPage_ArrayStrings()
        {
            

            var settings = new CitilinkSettings();

            var parserWorker = new ParserWorker<string[]>(settings);

            parserWorker.OnNewData += ParserWorker_OnNewData; ;
            parserWorker.OnCompleted += ParserWorker_OnCompleted;
            parserWorker.Start();

            Thread.Sleep(5000);

            Assert.IsTrue(isCompleted);
        }

        private void ParserWorker_OnNewData(object arg1,string[] arg2)
        {
            
                list.AddRange(arg2);
            
        }

        [TestMethod]
        public void GetFromLink_listStringUrl_listAnonimClass()
        {

        }

        private void ParserWorker_OnCompleted(object obj)
        {
            isCompleted = true;
        }

        //private void ParserWorker_OnNewData(object arg1, List<string> arg2)
        //{
        //    list.AddRange(arg2);
        //}
    }
}
