using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PraktyczneKursy.Infrastructure
{
    public static class UrlHelpers
    {
        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwaIkonyKategorii)
        {
            var IkonyKategoriFolder = AppConfig.IkonyKategoriFolderWzgledny;
            var sciezka = Path.Combine(IkonyKategoriFolder, nazwaIkonyKategorii);
            var sciezkaBezwzglendna = helper.Content(sciezka);

            return sciezkaBezwzglendna;
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var ObrazkiFolder = AppConfig.ObrazkiFolderWzgledny;
            var sciezka = Path.Combine(ObrazkiFolder, nazwaObrazka);
            var sciezkaBezwzglendna = helper.Content(sciezka);

            return sciezkaBezwzglendna;
        }
    }
}