using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.ViewComponenets.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetServiceByID(id);
            return View(values); 
        }
    }
}
