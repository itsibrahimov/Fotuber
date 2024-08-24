using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fotuber.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GettListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GettListWithReservationByWaitAprroval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in serviceManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ServiceID.ToString(),
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 3;
            p.Status = "Onay Bekliyor...";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}