using Microsoft.AspNetCore.Mvc;
using LogIn.Models;

namespace LogIn.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInModel model)
        {
            if (model.type == "User" && model.password=="user1@123")
            {
                return RedirectToAction("UserPage", model);
            }
            else if(model.type == "Admin")
            {
                return RedirectToAction("AdminPage", model);
            }
            return RedirectToAction("LogIn");
        }

        public IActionResult UserPage(LogInModel model)
        {
            return View(model);
        }

        public IActionResult AdminPage(LogInModel model)
        {
            return View(model);
        }


    }
}
