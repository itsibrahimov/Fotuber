using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fotuber.ViewComponenets.Default
{
    public class _Statistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Services.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
