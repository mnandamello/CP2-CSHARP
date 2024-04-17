using Microsoft.AspNetCore.Mvc;

namespace CP2_CSHARP.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
