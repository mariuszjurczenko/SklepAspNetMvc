using NLog;
using PraktyczneKursy.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraktyczneKursy.Controllers
{
    public class KursyController : Controller
    {      
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private KursyContext db;

        public KursyController(KursyContext context)
        {
            this.db = context;
        }

        // GET: Kursy
        public ActionResult Index()
        {
            var name = User.Identity.Name;
            logger.Info("Strona kursy | " + name);
            return View();
        }

        public ActionResult Lista(string nazwaKategori, string searchQuery = null)
        {
            var name = User.Identity.Name;
            logger.Info("Strona kategoria | " + nazwaKategori + " | " + name);
            var kategoria = db.Kategorie.Include("Kursy").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategori.ToUpper()).Single();

            var kursy = kategoria.Kursy.Where(a => (searchQuery == null ||
                                              a.TytulKursu.ToLower().Contains(searchQuery.ToLower()) ||
                                              a.AutorKursu.ToLower().Contains(searchQuery.ToLower())) &&
                                              !a.Ukryty);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_KursyList", kursy);
            }

            return View(kursy);
        }

        public ActionResult Szczegoly(int id)
        {          
            var kurs = db.Kursy.Find(id);
            var name = User.Identity.Name;
            logger.Info("Strona szczególy | " + kurs.TytulKursu + " | " + name);
            return View(kurs);
        }

        [ChildActionOnly]
        [OutputCache(Duration = 60000)]
        public ActionResult KategorieMenu()
        {      
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }

        public ActionResult KursyPodpowiedzi(string term)
        {
            var kursy = db.Kursy.Where(a => !a.Ukryty &&  a.TytulKursu.ToLower().Contains(term.ToLower()))
                        .Take(5).Select(a => new { label = a.TytulKursu });

            return Json(kursy, JsonRequestBehavior.AllowGet);
        }
    }
}