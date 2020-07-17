using Bertoni.DiegoTorres.Domain.Entity;
using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Constants;
using Bertoni.DiegoTorres.Service.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Concrete.RestApi
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
