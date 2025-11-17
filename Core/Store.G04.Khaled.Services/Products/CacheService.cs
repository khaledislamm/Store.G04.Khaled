using Store.G04.Khaled.Domain.Contracts;
using Store.G04.Khaled.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Products
{
    public class CacheService(ICacheRepository cacheRepository) : ICacheService
    {
        public async Task<string?> GetCacheValueAsync(string key)
        {
            var value = await cacheRepository.GetAsync(key);
            return value == null ? null : value;
        }

        public async Task SetCacheValueAsync(string key, object value, TimeSpan duration)
        {
            await cacheRepository.SetAsync(key, value, duration);
        }
    }
}
