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
        UniversalChatPluginEntities context = new UniversalChatPluginEntities();
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
        [HttpPost]
        public ActionResult Create(Admin m)
        {
            if (ModelState.IsValid)
            {
                context.Admins.Add(m);
                context.SaveChanges();
                ViewBag.msg = "Added Successfully";
                return RedirectToAction("All");
            }
            return RedirectToAction("Create");
        }

        public ActionResult All()
        {
            var admins = context.Admins.ToList();
            return View(admins);
        }

        public ActionResult Details(int Id)
        {
            var a = context.Admins.FirstOrDefault(e=>e.Id == Id);
            return View(a);
        }

        public ActionResult Edit(int Id)
        {
            var a = context.Admins.FirstOrDefault(e => e.Id == Id);
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(Admin m)
        {
            if (ModelState.IsValid)
            {
                var oldAdmin = context.Admins.FirstOrDefault(e => e.Id == m.Id);
                context.Entry(oldAdmin).CurrentValues.SetValues(m);
                context.SaveChanges();
                ViewBag.msg = "Updated Successfully";
                return RedirectToAction("All");
            }
            return RedirectToAction("Edit");
        }

        public ActionResult Delete(int Id)
        {
            var a = context.Admins.FirstOrDefault(e => e.Id == Id);
            return View(a);
        }
        [HttpPost]

        public ActionResult Delete(Admin m, int Id)
        {
            var a = context.Admins.FirstOrDefault(e => e.Id == Id);
            context.Admins.Remove(a);
            context.SaveChanges();
            ViewBag.msg = "Deleted Successfully";
            return RedirectToAction("All");
        }
    }
}