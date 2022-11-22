using Microsoft.AspNetCore.Mvc;
using UserRegisteration2.BAL.Respository;
using UserRegisteration2.DAL;
using UserRegisteration2.Models;

namespace UserRegisteration2.Controllers
{
    public class UserController : Controller
    {

       private readonly IUserRepository userRepository;

        public UserController(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }


        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult Registeration()
        {
            UserViewModel  userViewModel = new UserViewModel();
            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Registeration(UserViewModel userViewModel)
        {
            userRepository.Registeration(userViewModel);

            return View();
        }
        public IActionResult Delete()
        {
            userRepository.delete();


            

            return View();
        }

        
    }
}
