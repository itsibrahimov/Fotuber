using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}
