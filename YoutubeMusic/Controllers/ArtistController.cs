using Microsoft.AspNetCore.Mvc;
using YoutubeMusic.Models;

namespace YoutubeMusic.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            var artists = ArtistsRepository.GetArtist();
            return View(artists);
        }
    }
}
