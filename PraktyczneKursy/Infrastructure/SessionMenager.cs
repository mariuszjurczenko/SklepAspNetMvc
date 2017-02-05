using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace PraktyczneKursy.Infrastructure
{
    public class SessionMenager : ISessionMenager
    {
        private HttpSessionState session;

        public SessionMenager()
        {
            session = HttpContext.Current.Session;
        }
      
        public T Get<T>(string key)
        {
            return (T)session[key];
        }

        public void Set<T>(string name, T value)
        {
            session[name] = value;
        }

        public void Abandon()
        {
            session.Abandon();
        }

        public T TryGet<T>(string key)
        {
            try
            {
                return (T)session[key];
            }
            catch (NullReferenceException)
            {
                return default(T);
            }
        }
    }
}