using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
