using BLL.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities.FilmEntities;

namespace MVC.Controllers
{
    public class FilmController : Controller
    {
        private readonly IService<Film> _films;

        public FilmController(IService<Film> films)
        {
            _films = films;
        }
        public IActionResult Index()
        {
            var films = _films.GetAll();
            return View(films);
        }
    }
}
