using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.AdminDashboard
{
    public class _AdminGuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
