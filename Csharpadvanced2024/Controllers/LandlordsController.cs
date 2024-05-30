using Microsoft.AspNetCore.Mvc;

namespace Csharpadvanced2024.Controllers
{
    public class LandlordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
