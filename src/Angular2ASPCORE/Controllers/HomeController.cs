using Microsoft.AspNetCore.Mvc;

namespace Angular2ASPCORE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
