using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin m)
        {
            if (ModelState.IsValid)
            {
                bool b = true;
                if (b)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Error = "Your username & password does not match";
                }
            }
            return View();
        }
    }
}