using Bertoni.DiegoTorres.Service;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class CommentController : Controller
    {
        private CommentService _commentService = new CommentService();

        public JsonResult Get(int photoId)
        {
            var comments = _commentService.GetByPhotoId(photoId);

            return new JsonResult() { Data = comments };
        }
    }
}