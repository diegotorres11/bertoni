using Bertoni.DiegoTorres.Entity;
using System.Collections.Generic;
using System.Net.Http;

namespace Bertoni.DiegoTorres.Service
{
    public class CommentService
    {
        private string _endpoint = "http://jsonplaceholder.typicode.com/comments";
        private HttpClient _httpClient = new HttpClient();

        public IEnumerable<Comment> GetByPhotoId(int photoId)
        {
            string url = string.Format("{0}?postId={1}", _endpoint, photoId);
            var comments = new List<Comment>();
            var response = _httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                comments = response.Content.ReadAsAsync<List<Comment>>().Result;
            }

            return comments;
        }
    }
}
