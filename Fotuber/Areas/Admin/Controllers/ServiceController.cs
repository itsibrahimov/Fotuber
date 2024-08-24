using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
