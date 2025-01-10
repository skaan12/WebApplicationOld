using BLL.Services.Abstracts.FakeData;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities.FilmEntities;

namespace MVC.Controllers
{
    public class DataController : Controller
    {
        private readonly IFakeDataService<Artist> _artistFakeData;

        public DataController(IFakeDataService<Artist> artistFakeData)
        {
            _artistFakeData = artistFakeData;
        }
        [HttpGet("/data/populate-artists")]
        public async Task<IActionResult> PopulateArtists(int count = 50)
        {
            try
            {
                await _artistFakeData.AddFakeDataAsync(count);
                return Ok($"{count} adet sahte data eklendi");
            }
            catch (Exception ex)
            {
                return BadRequest("Bir hata oluştu");
            }
        }
    }
}
