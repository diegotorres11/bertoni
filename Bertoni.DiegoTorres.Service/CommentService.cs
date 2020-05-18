using Bertoni.DiegoTorres.Entity;
using Bertoni.DiegoTorres.Service.Constants;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public class CommentService
    {
        private HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<Comment>> GetByPhotoId(int photoId)
        {
            string url = string.Format("{0}?postId={1}", EndpointsConstants.Comments, photoId);
            var comments = new List<Comment>();
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                comments = await response.Content.ReadAsAsync<List<Comment>>();
            }

            return comments;
        }
    }
}
