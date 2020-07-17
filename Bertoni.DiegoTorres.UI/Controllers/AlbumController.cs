using Bertoni.DiegoTorres.Service.Abstract;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<ActionResult> Index()
        {
            var albums = await _albumService.GetAll();

            return View(albums);
        }
    }
}