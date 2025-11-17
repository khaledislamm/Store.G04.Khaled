using AutoMapper;
using Store.G04.Khaled.Domain.Contracts;
using Store.G04.Khaled.Domain.Entities.Products;
using Store.G04.Khaled.Domain.Exceptions;
using Store.G04.Khaled.Services.Abstractions.Products;
using Store.G04.Khaled.Shared.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Products
{
    public class BasketService(IBasketRepository basketRepository, IMapper mapper) : IBasketService
    {
        public async Task<BasketDto?> GetBasketAsync(string id)
        {
            var basket = await basketRepository.GetBasketAsync(id);
            if (basket is null) throw new BasketNotFoundException(id);
            var result = mapper.Map<BasketDto>(basket);
            return result;
        }

        public async Task<BasketDto?> UpdateBasketAsync(BasketDto basketDto)
        {
            var basket = mapper.Map<CustomerBasket>(basketDto);
            basket = await basketRepository.UpdateBasketAsync(basket);
            if (basket is null) throw new BasketCreateOrUpdateBadRequestException();
            var result = mapper.Map<BasketDto>(basket);
            return result;
        }

        public async Task<bool> DeleteBasketAsync(string id)
        {
            var flag = await basketRepository.DeleteBasketAsync(id);
            if (flag == false) throw new BasketDeleteBadRequestException();
            return flag;
        }
    }
}
