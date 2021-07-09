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
        // GET: Login
        public ActionResult Index()
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        public ActionResult Index(Login m, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var admin = context.Admins.FirstOrDefault(e => e.Username == m.Username);
                var organization = context.Organizations.FirstOrDefault(e => e.Username == m.Username);
                var user = context.Users.FirstOrDefault(e => e.Username == m.Username);
                if (admin != null)
                {
                    var password = context.Admins.FirstOrDefault(e => e.Password == m.Password);
                    if (password != null)
                    {
                        FormsAuthentication.SetAuthCookie(m.Username, false);
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        ViewBag.Error = "Your username & password does not match";
                    }
                }
                else if(organization != null)
                {
                    var password = context.Organizations.FirstOrDefault(e => e.Password == m.Password);
                    if (password != null)
                    {
                        FormsAuthentication.SetAuthCookie(m.Username, false);
                        return RedirectToAction("Index", "Organization");
                    }
                    else
                    {
                        ViewBag.Error = "Your username & password does not match";
                    }
                }
                else if (user != null)
                {
                    var password = context.Users.FirstOrDefault(e => e.Password == m.Password);
                    if (password != null)
                    {
                        FormsAuthentication.SetAuthCookie(m.Username, false);
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ViewBag.Error = "Your username & password does not match";
                    }
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
            return Redirect("/Login/Index");
        }
    }
}