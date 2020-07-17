using Bertoni.DiegoTorres.Domain.Entity;
using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Constants;
using Bertoni.DiegoTorres.Service.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service.Concrete.RestApi
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
