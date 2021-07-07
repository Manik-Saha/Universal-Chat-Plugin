using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    public class LoginController : Controller
    {
        UniversalChatPluginEntities context = new UniversalChatPluginEntities();
        Admin username = null;
        Admin password = null;
        // GET: Login
        public ActionResult Index()
        {
            Admin m = new Admin();
            return View(m);
        }

        [HttpPost]
        public ActionResult Index(Admin m, string returnUrl)
        {
                username = context.Admins.FirstOrDefault(e => e.Username == m.Username);
                if (username != null)
                {
                    password = context.Admins.FirstOrDefault(e => e.Password == m.Password);
                    if(password != null)
                    {
                        FormsAuthentication.SetAuthCookie(m.Username, false);
                    return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        ViewBag.Error = "Your username & password does not match";
                    }
                }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Admin/Index");
        }
    }
}