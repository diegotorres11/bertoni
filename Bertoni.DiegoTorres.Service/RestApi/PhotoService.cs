using Bertoni.DiegoTorres.Entity;
using Bertoni.DiegoTorres.Service.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public class PhotoService : IPhotoService
    {
        WebServiceConsumer _consumer = new WebServiceConsumer();

        public async Task<IEnumerable<Photo>> GetAll()
        {
            var photos = await _consumer.ConsumeCollection<Photo>(EndpointsConstants.Photos);

            return photos;
        }

        public async Task<IEnumerable<Photo>> GetByAlbumId(int albumId)
        {
            string url = string.Format("{0}?albumId={1}", EndpointsConstants.Photos, albumId);
            var photos = await _consumer.ConsumeCollection<Photo>(url);

            return photos;
        }
    }
}
