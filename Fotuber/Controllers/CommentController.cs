using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fotuber.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommenState = true;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Service");
        }
    }
}
