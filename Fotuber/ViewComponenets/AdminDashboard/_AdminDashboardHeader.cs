using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
