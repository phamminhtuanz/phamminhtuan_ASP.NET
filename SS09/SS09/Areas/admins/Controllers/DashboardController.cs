using Microsoft.AspNetCore.Mvc;

namespace SS09.Areas.admins.Controllers
{
    //[Area("admins")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
