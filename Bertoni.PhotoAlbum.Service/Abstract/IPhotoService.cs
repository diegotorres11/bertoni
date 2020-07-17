using Bertoni.DiegoTorres.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Abstract
{
    public interface IPhotoService
    {
        Task<IEnumerable<Photo>> GetAll();
        Task<IEnumerable<Photo>> GetByAlbumId(int albumId);
    }
}
