using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            Admin m = new Admin();
            return View(m);
        }
    }
}