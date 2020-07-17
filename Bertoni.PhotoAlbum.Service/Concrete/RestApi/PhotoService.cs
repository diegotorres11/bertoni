using Bertoni.DiegoTorres.Domain.Entity;
using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Constants;
using Bertoni.DiegoTorres.Service.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Concrete.RestApi
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
