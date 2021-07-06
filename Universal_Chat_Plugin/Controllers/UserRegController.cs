using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Universal_Chat_Plugin.Controllers
{
    public class UserRegController : Controller
    {
        // GET: UserReg
        public ActionResult Register()
        {
            return View();
        }
        /*[HttpPost]
        public ActionResult Register(Person p)
        {
            Database db = new Database();
            
        }*/
    }
}