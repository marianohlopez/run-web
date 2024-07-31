using Microsoft.AspNetCore.Mvc;

namespace runWebApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
