using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
