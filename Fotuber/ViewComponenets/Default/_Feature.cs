using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
           // ViewBag.image1 = featureManager.
            return View();
        }
    }
}
