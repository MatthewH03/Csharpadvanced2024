using Microsoft.AspNetCore.Mvc;

namespace Csharpadvanced2024.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
