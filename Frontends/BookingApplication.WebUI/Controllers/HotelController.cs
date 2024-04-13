using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebUI.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hotels";
            ViewBag.v2 = "Our Hotels";
            return View();
        }
    }
}
