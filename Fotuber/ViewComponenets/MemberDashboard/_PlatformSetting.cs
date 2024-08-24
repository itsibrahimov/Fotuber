using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
