using CP2_CSHARP.DATA;
using CP2_CSHARP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CP2_CSHARP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register(User resquest)
        {
            var user = _dataContext.MVC_USUARIO.FirstOrDefault(x => x.UserEmail == resquest.UserEmail);
            if (user != null)
            {
                return BadRequest("Usuário ja existe");
            }
            User newUser = new User
            {
                id = resquest.id,
                UserEmail = resquest.UserEmail,
                UserName = resquest.UserName,
                UserPassword = resquest.UserPassword,
            };
            _dataContext.Add(newUser);
            _dataContext.SaveChanges();
            return View();
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
