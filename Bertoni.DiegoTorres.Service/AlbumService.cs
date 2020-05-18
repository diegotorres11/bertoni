using Bertoni.DiegoTorres.Entity;
using Bertoni.DiegoTorres.Service.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public class AlbumService
    {
        HttpClient _client = new HttpClient();

        public async Task<IEnumerable<Album>> GetAll()
        {
            var albums = new List<Album>();
            var response = await _client.GetAsync(EndpointsConstants.Albums);

            if (response.IsSuccessStatusCode)
            {
                albums = await response.Content.ReadAsAsync<List<Album>>();
            }

            return albums;
        }
    }
}
