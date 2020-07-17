using Bertoni.DiegoTorres.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Abstract
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetByPhotoId(int photoId);
    }
}
