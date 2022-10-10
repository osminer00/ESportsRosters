using Microsoft.AspNetCore.Mvc;

namespace ESportsRosters.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
