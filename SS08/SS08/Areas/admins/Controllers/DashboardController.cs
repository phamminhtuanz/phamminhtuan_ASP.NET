using Microsoft.AspNetCore.Mvc;

namespace SS08.Areas.admins.Controllers
{
    [Area("admins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
