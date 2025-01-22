using BLL.Services.Abstracts;
using BLL.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;
using MODEL.Abstract.Enums;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFilmService _filmService;

        public HomeController(ILogger<HomeController> logger,IFilmService filmService )
        {
            _logger = logger;
            _filmService = filmService;
        }

        public IActionResult Index()
        {
            var films = _filmService.GetActives();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register(string membershipType) 
        {
            MembershipType parsedMembershipType;

            if (Enum.TryParse<MembershipType>(membershipType,true,out parsedMembershipType))
            {
                var registerVM = new RegisterVM()
                {
                    MembershipType = parsedMembershipType
                };
                return View(registerVM);
            }
            else
            {
                var registerVM = new RegisterVM()
                {
                    MembershipType = MembershipType.Basic
                };
                return View(registerVM);
            }

        }        
        [HttpPost]        
        public IActionResult Register(RegisterVM registerVM)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
