using Store.G04.Khaled.Shared.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Abstractions.Products
{
    public interface IBasketService
    {
        Task<BasketDto?> GetBasketAsync(string id);
        Task<BasketDto?> UpdateBasketAsync(BasketDto basketDto);
        Task<bool> DeleteBasketAsync(string id);
    }
}
