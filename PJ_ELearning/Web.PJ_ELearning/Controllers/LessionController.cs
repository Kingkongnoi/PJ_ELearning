using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.PJ_ELearning.Controllers
{
    public class LessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
