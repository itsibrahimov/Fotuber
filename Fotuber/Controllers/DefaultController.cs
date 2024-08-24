using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
