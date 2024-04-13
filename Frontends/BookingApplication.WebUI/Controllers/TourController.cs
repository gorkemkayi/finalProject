using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebUI.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Tours";
            ViewBag.v2 = "Our Tours";
            return View();
        }
    }
}
