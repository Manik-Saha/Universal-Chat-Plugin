using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    public class HomeController : Controller
    {
        UniversalChatPluginEntities context = new UniversalChatPluginEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserRegistration()
        {
            User u = new User();
            return View(u);
        }
        [HttpPost]
        public ActionResult UserRegistration(User u)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(u);
                context.SaveChanges();
                TempData["msg"] = "Added Successfully";
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}