using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universal_Chat_Plugin.Models;

namespace Universal_Chat_Plugin.Controllers
{
    [Authorize]
    public class OrganizationController : Controller
    {
        UniversalChatPluginEntities context = new UniversalChatPluginEntities();
        // GET: Organization
        public ActionResult Index()
        {
            var organizations = context.Organizations.ToList();
            return View(organizations);
        }

        public ActionResult Create()
        {
            Organization o = new Organization();
            return View(o);
        }
        [HttpPost]
        public ActionResult Create(Organization o)
        {
            if (ModelState.IsValid)
            {
                context.Organizations.Add(o);
                context.SaveChanges();
                TempData["msg"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int Id)
        {
            var o = context.Organizations.FirstOrDefault(e => e.Id == Id);
            return View(o);
        }

        public ActionResult Edit(int Id)
        {
            var o = context.Organizations.FirstOrDefault(e => e.Id == Id);
            return View(o);
        }
        [HttpPost]
        public ActionResult Edit(Organization o)
        {
            if (ModelState.IsValid)
            {
                var oldOrganization = context.Organizations.FirstOrDefault(e => e.Id == o.Id);
                context.Entry(oldOrganization).CurrentValues.SetValues(o);
                context.SaveChanges();
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var o = context.Organizations.FirstOrDefault(e => e.Id == Id);
            return View(o);
        }
        [HttpPost]
        public ActionResult Delete(Organization o, int Id)
        {
            var a = context.Organizations.FirstOrDefault(e => e.Id == Id);
            context.Organizations.Remove(a);
            context.SaveChanges();
            TempData["msg"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}