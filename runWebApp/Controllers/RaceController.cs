using Microsoft.AspNetCore.Mvc;

namespace runWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
