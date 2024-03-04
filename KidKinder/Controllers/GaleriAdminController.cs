using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class GaleriAdminController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Galleries.ToList();
            return View(values);
        }

        // Yeni galeri ekleme sayfası
        [HttpGet]
        public ActionResult CreateGallery()
        {
            return View();
        }

        // Yeni galeri ekleme işlemi
        [HttpPost]
        public ActionResult CreateGallery(Gallery gallery)
        {
            context.Galleries.Add(gallery);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GalleryUpdate(int id)
        {
            var galeri = context.Galleries.Find(id);
            return View(galeri);
        }

        // Galeri güncelleme işlemi
        [HttpPost]
        public ActionResult GalleryUpdate(Gallery gallery)
        {
            var values = context.Galleries.Find(gallery.GalleryId);
            values.ImageUrl = gallery.ImageUrl;
            values.Status = gallery.Status; // Durumun güncellenmesi eklendi
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Galeri silme işlemi
        public ActionResult GalleryDelete(int id)
        {
            var values = context.Galleries.Find(id);
            context.Galleries.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Resmin durumunu güncelleme işlemi
        public ActionResult ImageStatusUpdate(int id)
        {
            var values = context.Galleries.Find(id);
            values.Status = !values.Status; // Durumu tersine çevir (aktifse pasif, pasifse aktif yap)
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
    