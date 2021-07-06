using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universal_Chat_Plugin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        /*public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin m)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                bool b = db.Admins.CheckAdmin(m);
                if (b)
                {
                    return RedirectToAction("Index", "");
                }
                else
                {
                    ViewBag.Error = "Your username & password does not match";
                }
            }
            return View();
        }*/
    }
}