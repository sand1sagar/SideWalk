using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sidewalk.Logic.Caching
{
    public static class CacheEngine
    {
        static int cacheExpireTime = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["CacheTimeOut"]);
        public static void Add(string key, object o, int expire = 1440)
        {
            expire = cacheExpireTime;
            HttpRuntime.Cache.Insert(
                key,
                o,
                null,
                DateTime.Now.AddMinutes(expire),//in minutes
                System.Web.Caching.Cache.NoSlidingExpiration);
        }

        public static void Clear(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }

        public static bool Exists(string key)
        {
            return HttpRuntime.Cache[key] != null;
        }

        public static object Get(string key)
        {
            try
            {
                return HttpRuntime.Cache[key];
            }
            catch
            {
                return null;
            }
        }

    }
}
