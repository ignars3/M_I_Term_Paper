using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hygieia.Controllers
{
    public class DrugController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
