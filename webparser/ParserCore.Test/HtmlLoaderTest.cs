using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserCore.Ciitilink;
using ParserCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Test
{
    [TestClass]
    class HtmlLoaderTest
    {
        [TestMethod]
        public void GetSourceById_int_string()
        {
            var settings = new CitilinkSettings(1, 2);
            var loader = new HtmlLoader(settings);

            var result = loader.GetSourceByPageId(1);

            Assert.AreEqual(result, "test");
        }
    }
}
