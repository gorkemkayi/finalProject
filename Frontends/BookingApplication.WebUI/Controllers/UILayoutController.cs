using Microsoft.AspNetCore.Mvc;

namespace BookingApplication.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
