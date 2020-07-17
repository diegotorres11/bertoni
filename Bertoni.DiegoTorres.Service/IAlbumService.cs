using Bertoni.DiegoTorres.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAll();
    }
}
