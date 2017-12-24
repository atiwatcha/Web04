using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web04.Controllers
{
    public class PlaylistsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}