using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UniversalChatPluginEntities context = new UniversalChatPluginEntities();
        // GET: User
        public ActionResult Index()
        {
            var users = context.Users.ToList();
            return View(users);
        }
        public ActionResult Create()
        {
            User u = new User();
            return View(u);
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            if (ModelState.IsValid)
            {
                context.Users.Add(u);
                context.SaveChanges();
                TempData["msg"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var u = context.Users.FirstOrDefault(e => e.Id == Id);
            return View(u);
        }
        [HttpPost]
        public ActionResult Edit(User u)
        {
            if (ModelState.IsValid)
            {
                var oldUser = context.Users.FirstOrDefault(e => e.Id == u.Id);
                context.Entry(oldUser).CurrentValues.SetValues(u);
                context.SaveChanges();
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int Id)
        {
            var u = context.Users.FirstOrDefault(e => e.Id == Id);
            return View(u);
        }
        public ActionResult Delete(int Id)
        {
            var u = context.Users.FirstOrDefault(e => e.Id == Id);
            return View(u);
        }
        [HttpPost]
        public ActionResult Delete(User u, int Id)
        {
            var user = context.Users.FirstOrDefault(e => e.Id == Id);
            context.Users.Remove(user);
            context.SaveChanges();
            TempData["msg"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }

    }
}