using KidKinder.Context;
using KidKinder.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class MessageController : Controller
    {
       KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        public ActionResult DeleteSelectedMessages(FormCollection form)
        {
            string[] seciliid = form["secim_id"].Split(new char[] { ',' });
            foreach (string id in seciliid)
            {
                Contact contact = context.Contacts.Find(int.Parse(id));
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}