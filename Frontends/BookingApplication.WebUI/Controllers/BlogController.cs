using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Our Blogs";
            return View();
        }

        public IActionResult BlogDetail(int id)
        {
            ViewBag.v1 = "Blogs";
            ViewBag.v2 = "Blog Details";
            ViewBag.blogid=id;
            return View();
        }
    }   
}
