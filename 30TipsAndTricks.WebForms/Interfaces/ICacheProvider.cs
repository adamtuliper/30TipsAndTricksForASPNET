using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Developed by Adam Tuliper   @AdamTuliper
 * completedevelopment.blogspot.com
 * adam.tuliper@gmail.com
 * Please retain credits if you use this code, use though without restrictions.
 */
namespace _30TipsAndTricks.WebForms.Interfaces
{
    /// <summary>
    /// Provides an interface to a strongly typed cache implementation that avoids casting upon assignment
    /// </summary>
    public interface ICacheProvider
    {
        T Get<T>(string key);
        void Add<T>(string key, T data, int cacheTime);
        bool Exists(string key);
        void Remove(string key);
    }
}
