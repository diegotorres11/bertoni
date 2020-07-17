using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Util
{
    public class WebServiceConsumer
    {
        HttpClient _client = new HttpClient();

        public async Task<IEnumerable<T>> ConsumeCollection<T>(string url)
        {
            var collection = Enumerable.Empty<T>();
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                collection = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }

            return collection;
        }
    }
}
