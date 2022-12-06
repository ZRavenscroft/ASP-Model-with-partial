using Microsoft.AspNetCore.Mvc;

namespace PustokLayout.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();  
        }
    }
}
