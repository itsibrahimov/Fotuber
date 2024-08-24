using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace Fotuber.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithService();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
