using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParserCore.Core
{
    public class HtmlLoader
    {
        readonly HttpClient client; // HttpClient - класс
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
            client = new HttpClient();
        }
        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
