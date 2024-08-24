using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PackageController : Controller
    {
        private readonly IServiceService _serviceService;

        public PackageController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PackageList()
        {
            var jsonPackage = JsonConvert.SerializeObject(_serviceService.TGetList());
            return Json(jsonPackage);
        }

        [HttpPost]
        public IActionResult AddPackageService(Service service)
        {
            service.Status = true;
            _serviceService.TAdd(service);
            var values = JsonConvert.SerializeObject(service);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _serviceService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeletePackage(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdatePackage(Service service)
        {
            _serviceService.TUpdate(service);
            var v = JsonConvert.SerializeObject(service);
            return Json(v);
        }
    }
}
