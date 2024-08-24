using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ServiceDetails(int id)
        {
            ViewBag.i = id;
            var values = serviceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ServiceDetails(Service p)
        {
            return View();
        }
    }
}
