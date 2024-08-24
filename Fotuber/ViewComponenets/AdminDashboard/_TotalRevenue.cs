using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.AdminDashboard
{
    public class _TotalRevenue : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
