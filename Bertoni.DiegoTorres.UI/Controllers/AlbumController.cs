using Bertoni.DiegoTorres.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumService _albumService = new AlbumService();

        public async Task<ActionResult> Index()
        {
            var albums = await _albumService.GetAll();

            return View(albums);
        }
    }
}