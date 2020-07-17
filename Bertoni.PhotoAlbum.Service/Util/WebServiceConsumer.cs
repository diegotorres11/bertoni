using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.PhotoAlbum.Service.Util
{
    public class WebServiceConsumer
    {
        private static HttpClient _client;
        private static volatile object _locker = new object();

        private static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    lock (_locker)
                    {
                        if (_client == null)
                        {
                            _client = new HttpClient();
                        }
                    }
                }

                return _client;
            }
        }

        public async Task<IEnumerable<T>> ConsumeCollection<T>(string url)
        {
            var collection = Enumerable.Empty<T>();
            var response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                collection = await response.Content.ReadAsAsync<IEnumerable<T>>();
            }

            return collection;
        }
    }
}
