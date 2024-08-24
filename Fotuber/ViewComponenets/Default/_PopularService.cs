using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.Default
{
    public class _PopularService : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
