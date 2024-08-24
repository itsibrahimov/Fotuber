using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
