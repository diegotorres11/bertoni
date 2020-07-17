using Bertoni.PhotoAlbum.Domain.Entity;
using Bertoni.PhotoAlbum.Service.Abstract;
using Bertoni.PhotoAlbum.Service.Constants;
using Bertoni.PhotoAlbum.Service.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.PhotoAlbum.Service.Concrete.RestApi
{
    public class CommentService : ICommentService
    {
        private WebServiceConsumer _consumer = new WebServiceConsumer();

        public async Task<IEnumerable<Comment>> GetByPhotoId(int photoId)
        {
            string url = string.Format("{0}?postId={1}", EndpointsConstants.Comments, photoId);
            var comments = await _consumer.ConsumeCollection<Comment>(url);

            return comments;
        }
    }
}
