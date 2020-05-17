using Bertoni.DiegoTorres.Entity;
using System.Collections.Generic;
using System.Net.Http;

namespace Bertoni.DiegoTorres.Service
{
    public class AlbumService
    {
        string endpoint = "http://jsonplaceholder.typicode.com/albums";

        public IEnumerable<Album> GetAll()
        {
            HttpClient client = new HttpClient();
            var albums = new List<Album>();

            var response = client.GetAsync(endpoint).Result;

            if (response.IsSuccessStatusCode)
            {
                albums = response.Content.ReadAsAsync<List<Album>>().Result;
            }

            return albums;
        }
    }
}
