using Bertoni.DiegoTorres.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class CommentController : Controller
    {
        private CommentService _commentService = new CommentService();

        public async Task<JsonResult> Get(int photoId)
        {
            var comments = await _commentService.GetByPhotoId(photoId);

            return new JsonResult() { Data = comments };
        }
    }
}