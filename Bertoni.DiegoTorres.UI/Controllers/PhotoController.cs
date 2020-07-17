using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Concrete.RestApi;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class PhotoController : Controller
    {
        private IPhotoService _photoService = new PhotoService();

        public async Task<PartialViewResult> Get(int albumId)
        {
            var photos = await _photoService.GetByAlbumId(albumId);

            return PartialView("Partial/_PhotosPartial", photos);
        }
    }
}
