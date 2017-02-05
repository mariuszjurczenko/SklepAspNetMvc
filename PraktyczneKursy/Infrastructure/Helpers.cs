using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PraktyczneKursy.Infrastructure
{
    public class Helpers
    {
        public static void CallUrl(string url)
        {
            var req = HttpWebRequest.Create(url);
            req.GetResponseAsync();
        }
    }
}