using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using _30TipsAndTricks.Interfaces;

/*
 * Developed by Adam Tuliper   @AdamTuliper
 * completedevelopment.blogspot.com
 * adam.tuliper@gmail.com
 * Please retain credits if you use this code, use though without restrictions.
 */
namespace _30TipsAndTricks.Cache
{
    /// <summary>
    /// NET Memory cache wrapper around the ICacheProvider interface to support strongly typed cache retrievals. 
    /// </summary>
    public class MemoryCacheProvider : ICacheProvider
    {
        private static ObjectCache Cache { get { return MemoryCache.Default; } }

        /// <summary>
        /// A strongly typed method to retrieve an iten from the cache. This prevents having to cast all over in your code.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        /// <summary>
        /// Adds an item to the cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="data">The object to store in the cache</param>
        /// <param name="cacheTime">The time in seconds to cache</param>
        public void Add<T>(string key, T data, int cacheTime)
        {
            var itemPolicy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromSeconds(cacheTime) };

            Cache.Add(new CacheItem(key, data), itemPolicy);
        }

        /// <summary>
        /// Checks if an item in the cache exists
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exists(string key)
        {
            return (Cache[key] != null);
        }

        /// <summary>
        /// Remove an item from the cache
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Cache.Remove(key);
        }
    }
}