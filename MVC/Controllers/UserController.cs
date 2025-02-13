using BLL.Services.Abstracts.UserAbstracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities.UserEntities;
using MVC.Models.ViewModels;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAdmin(AddAdminVM model)
        {
            if (ModelState.IsValid)
            {
                User adminUser = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    UserType = MODEL.Abstract.Enums.UserType.Admin,
                    CVC = model.CVC,
                    CreditCardNumber = model.CreditCard
                };
                await _userService.CreateUserAsync(adminUser, model.Password, model.CVC, model.CreditCard);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
