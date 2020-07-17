using Bertoni.PhotoAlbum.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.PhotoAlbum.Service.Abstract
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetByPhotoId(int photoId);
    }
}
