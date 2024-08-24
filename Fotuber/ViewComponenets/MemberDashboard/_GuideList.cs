using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke ()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
