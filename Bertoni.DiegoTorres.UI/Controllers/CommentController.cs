﻿using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Concrete.RestApi;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService _commentService = new CommentService();

        public async Task<PartialViewResult> Get(int photoId = 1)
        {
            var comments = await _commentService.GetByPhotoId(photoId);

            return PartialView("Partial/_CommentsPartial", comments);
        }
    }
}