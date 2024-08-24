using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fotuber.ViewComponenets.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Services.Count();
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
