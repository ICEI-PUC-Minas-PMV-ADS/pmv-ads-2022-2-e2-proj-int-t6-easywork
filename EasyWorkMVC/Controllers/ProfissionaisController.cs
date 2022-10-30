using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWorkMVC.Controllers
{
    public class ProfissionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
