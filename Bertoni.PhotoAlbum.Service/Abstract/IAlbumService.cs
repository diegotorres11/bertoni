using Bertoni.PhotoAlbum.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.PhotoAlbum.Service.Abstract
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAll();
    }
}
