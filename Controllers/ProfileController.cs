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
        public ActionResult Accounts()
        {
            //var allusers = context.Users.ToList();
            //var users = allusers.Where(x => x.Roles.Select(role => role.Name).Contains("User")).ToList();
            //var userVM = users.Select(user => new UserViewModel { Username = user.FullName, Roles = string.Join(",", user.Roles.Select(role => role.Name)) }).ToList();

            // var admins = allusers.Where(x => x.Roles.Select(role => role.Name).Contains("Admin")).ToList();
            //var adminsVM = admins.Select(user => new UserViewModel { Username = user.FullName, Roles = string.Join(",", user.Roles.Select(role => role.Name)) }).ToList();
            //var model = new GroupedUserViewModel { Users = userVM, Admins = adminsVM };

            //return View(model);
            return View();
        }
    }
}
