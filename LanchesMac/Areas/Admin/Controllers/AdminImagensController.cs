using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    public class AdminImagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
