using Bertoni.DiegoTorres.Service.Abstract;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class PhotoController : Controller
    {
        private IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<PartialViewResult> Get(int albumId)
        {
            var photos = await _photoService.GetByAlbumId(albumId);

            return PartialView("Partial/_PhotosPartial", photos);
        }
    }
}
