using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Concrete.RestApi;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumService _albumService = new AlbumService();

        public async Task<ActionResult> Index()
        {
            var albums = await _albumService.GetAll();

            return View(albums);
        }
    }
}