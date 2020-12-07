using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SurplusDeficitAutomationSystem.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult UserAccount()
        {
            return View();
        }
        public ViewResult Index()
        {
            return View();
        }
        public IActionResult AdminAccount()
        {
            return View();
        }
    }
}
