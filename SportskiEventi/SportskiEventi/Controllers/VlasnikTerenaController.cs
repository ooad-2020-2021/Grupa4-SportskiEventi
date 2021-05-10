using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportskiEventi.Controllers
{
    public class VlasnikTerenaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
