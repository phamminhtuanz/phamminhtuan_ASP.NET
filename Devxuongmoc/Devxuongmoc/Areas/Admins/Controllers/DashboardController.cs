using Microsoft.AspNetCore.Mvc;

namespace Devxuongmoc.Areas.Admins.Controllers
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
