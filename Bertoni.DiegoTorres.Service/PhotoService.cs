using Bertoni.DiegoTorres.Entity;
using System.Collections.Generic;
using System.Net.Http;

namespace Bertoni.DiegoTorres.Service
{
    public class PhotoService
    {
        HttpClient _client = new HttpClient();
        string _endpoint = "http://jsonplaceholder.typicode.com/photos";

        public IEnumerable<Photo> GetAll()
        {
            var photos = new List<Photo>();
            var response = _client.GetAsync(_endpoint).Result;

            if (response.IsSuccessStatusCode)
            {
                photos = response.Content.ReadAsAsync<List<Photo>>().Result;
            }

            return photos;
        }

        public IEnumerable<Photo> GetByAlbumId(int albumId)
        {
            string url = string.Format("{0}?albumId={1}", _endpoint, albumId);
            var photos = new List<Photo>();
            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                photos = response.Content.ReadAsAsync<List<Photo>>().Result;
            }

            return photos;
        }
    }
}
