using Microsoft.AspNetCore.Mvc;

namespace ClientCertificationAuthentication_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
