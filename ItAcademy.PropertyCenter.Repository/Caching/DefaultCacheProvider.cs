using System;
using System.Runtime.Caching;

namespace ItAcademy.PropertyCenter.Repository.Caching
{
    public interface ICacheProvider
    {
        object Get(string key);

        void Set(string key, object data, int cacheTime);

        bool IsSet(string key);

        void Invalidate(string key);
    }

    public class DefaultCacheProvider : ICacheProvider
    {
        protected ObjectCache Cache { get { return MemoryCache.Default; } }

        public object Get(string key)
        {
            return Cache[key];
        }

        public void Set(string key, object data, int cacheTime)
        {
            CacheItemPolicy policy = new CacheItemPolicy() { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime) };

            if (IsSet(key)) return;

            Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsSet(string key)
        {
            return Cache[key] != null;
        }

        public void Invalidate(string key)
        {
            Cache.Remove(key);
        }
    }
}
