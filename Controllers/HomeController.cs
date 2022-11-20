using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseDapper.BissnesLogic.Interface;
using UseDapper.Models;

namespace UseDapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBL userBL;

        public HomeController(ILogger<HomeController> logger,IUserBL userBL)
        {
            _logger = logger;
            this.userBL = userBL;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                int? userID = userBL.Authenticate(model.Email, model.Password);
                if (userID == 0)
                {
                    return View(userBL.GetUserById(userID.Value));
                }

            }
            return View(null);
        }

        public IActionResult Privacy()
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