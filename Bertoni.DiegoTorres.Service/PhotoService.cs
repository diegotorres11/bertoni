using Bertoni.DiegoTorres.Entity;
using Bertoni.DiegoTorres.Service.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public class PhotoService
    {
        HttpClient _client = new HttpClient();

        public async Task<IEnumerable<Photo>> GetAll()
        {
            var photos = new List<Photo>();
            var response = await _client.GetAsync(EndpointsConstants.Photos);

            if (response.IsSuccessStatusCode)
            {
                photos = await response.Content.ReadAsAsync<List<Photo>>();
            }

            return photos;
        }

        public async Task<IEnumerable<Photo>> GetByAlbumId(int albumId)
        {
            string url = string.Format("{0}?albumId={1}", EndpointsConstants.Photos, albumId);
            var photos = new List<Photo>();
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                photos = await response.Content.ReadAsAsync<List<Photo>>();
            }

            return photos;
        }
    }
}
