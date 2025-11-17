using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Abstractions
{
    public interface ICacheService
    {
        Task SetCacheValueAsync(string key, object value, TimeSpan duration);
        Task<string?> GetCacheValueAsync(string key);
    }
}
