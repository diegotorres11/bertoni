using Bertoni.DiegoTorres.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class PhotoController : Controller
    {
        private PhotoService _photoService = new PhotoService();

        public async Task<JsonResult> Get(int albumId)
        {
            var photos = await _photoService.GetByAlbumId(albumId);

            return new JsonResult() { Data = photos };
        }
    }
}