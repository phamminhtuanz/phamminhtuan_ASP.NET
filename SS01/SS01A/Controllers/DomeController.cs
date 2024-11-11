using Microsoft.AspNetCore.Mvc;

namespace SS01A.Controllers
{
    public class DomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
