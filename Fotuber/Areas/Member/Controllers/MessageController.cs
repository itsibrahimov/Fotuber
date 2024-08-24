using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
