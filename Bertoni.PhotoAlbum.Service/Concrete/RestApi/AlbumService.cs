using Bertoni.PhotoAlbum.Domain.Entity;
using Bertoni.PhotoAlbum.Service.Abstract;
using Bertoni.PhotoAlbum.Service.Constants;
using Bertoni.PhotoAlbum.Service.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.PhotoAlbum.Service.Concrete.RestApi
{
    public class AlbumService : IAlbumService
    {
        WebServiceConsumer _consumer = new WebServiceConsumer();

        public async Task<IEnumerable<Album>> GetAll()
        {
            var albums = await _consumer.ConsumeCollection<Album>(EndpointsConstants.Albums);

            return albums;
        }
    }
}
