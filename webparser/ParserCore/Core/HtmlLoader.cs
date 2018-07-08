using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParserCore.Core
{
    /// <summary>
    /// Предназначен для получения HTML документа с помощью стандартного системного класса по переданному в метод url.
    /// HttpClient
    /// </summary>
    internal class HtmlLoader
    {
        #region flds

        private readonly HttpClient client; // HttpClient - класс

        #endregion flds

        #region ctors

        public HtmlLoader()
        {
            client = new HttpClient();
        }

        #endregion ctors

        #region public mthds

        internal async Task<string> GetSourceByUrl(string url)
        {
            var response = await client.GetAsync(url);
            string source = null;
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }

        #endregion public mthds
    }
}