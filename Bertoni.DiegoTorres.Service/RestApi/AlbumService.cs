using Bertoni.DiegoTorres.Domain.Entity;
using Bertoni.DiegoTorres.Service.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
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
