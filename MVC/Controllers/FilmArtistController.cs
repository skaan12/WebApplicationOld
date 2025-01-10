using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using MODEL.Abstract.Interfaces;
using MODEL.Entities.FilmEntities;

namespace MVC.Controllers
{
    [Route("FilmArtist")]
    public class FilmArtistController : Controller
    {
        private readonly IJoinService<FilmArtist, int, int> _filmArtistService;
       
       
        public FilmArtistController(IJoinService<FilmArtist,int,int> filmArtistService)
            
        {
            _filmArtistService = filmArtistService;
            
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("AddFakeData")]
        public async Task<IActionResult> AddFakeData()
        {
            var films = Enumerable.Range(31, 28).ToList();
            var artistIds = Enumerable.Range(1, 50).ToList();

            var random = new Random();

            foreach (var filmid in films)
            {
                var selectedArtistIds = artistIds.OrderBy(x => random.Next()).Take(3).ToList();

                var role = "Actor";

                await _filmArtistService.AddMultipleArtistForFilmAsync(filmid, selectedArtistIds, role);
            }
            return Ok("Fake data succesfully added to all films");
        }
    }
}
