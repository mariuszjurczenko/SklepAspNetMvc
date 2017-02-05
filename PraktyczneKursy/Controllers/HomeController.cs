using Microsoft.AspNet.Identity;
using NLog;
using PraktyczneKursy.DAL;
using PraktyczneKursy.Infrastructure;
using PraktyczneKursy.Models;
using PraktyczneKursy.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace PraktyczneKursy.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private KursyContext db;
        ICacheProvider cache;       

        public HomeController(KursyContext context, ICacheProvider cache)
        {
            this.db = context;
            this.cache = cache;
        }

        public ActionResult Index()
        {
            //var name = User.Identity.Name;
            //logger.Info("Strona główna | " + name);

            List<Kategoria> kategorie;

            db.Database.Log = message => Trace.WriteLine(message);

            if (cache.IsSet(Consts.KategorieCacheKey))
                kategorie = cache.Get(Consts.KategorieCacheKey) as List<Kategoria>;
            else
            {
                kategorie = db.Kategorie.ToList();
                cache.Set(Consts.KategorieCacheKey, kategorie, 60);
            }

            var nowosci = db.Kursy.Where(a => !a.Ukryty).OrderByDescending(a => a.DataDodania).Take(3);
            var bestseller = db.Kursy.Where(a => !a.Ukryty && a.Bestseller).OrderBy(a => Guid.NewGuid()).Take(3);

            var vm = new HomeViewModel()
            {
                Kategorie = kategorie,
                Nowosci = nowosci,
                Bestsellery = bestseller
            };

            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
           // var name = User.Identity.Name;
          //  logger.Info("Strona " + nazwa + " | " + name);
            return View(nazwa);
        }
    }
}