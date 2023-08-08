using Microsoft.AspNetCore.Mvc;

namespace MotelManagement.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
