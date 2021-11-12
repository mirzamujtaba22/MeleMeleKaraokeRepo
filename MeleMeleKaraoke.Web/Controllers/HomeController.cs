using MeleMeleKaraoke.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeleMeleKaraoke.Web.Controllers
{
    public class HomeController : Controller
    {

        public RoomService roomService;
        public HomeController(RoomService roomService)
        {
            this.roomService = roomService;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
