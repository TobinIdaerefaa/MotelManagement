using Microsoft.AspNetCore.Mvc;
using MotelManagement.Models;

namespace MotelManagement.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult List()
        {
            Room rooms = new Room();

            return View(rooms.GetAllRooms());
        }

        public IActionResult Create()
        {
            return View();
        }

        [Route("Rooms/Details/{id}")]
        public IActionResult Details(int id)
        {
            Room rooms = new Room();
            return View(rooms.RoomDetail(id));
        }
    }
}
