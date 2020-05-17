using Bertoni.DiegoTorres.Service;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumService _albumService = new AlbumService();
        private PhotoService _photoService = new PhotoService();

        public ActionResult Index()
        {
            var albums = _albumService.GetAll();

            return View(albums);
        }

        public JsonResult GetPhotos(int albumId)
        {
            var photos = _photoService.GetByAlbumId(albumId);

            return new JsonResult() { Data = photos };
        }
    }
}