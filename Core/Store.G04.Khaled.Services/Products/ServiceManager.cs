using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Store.G04.Khaled.Domain.Contracts;
using Store.G04.Khaled.Domain.Entities.Identity;
using Store.G04.Khaled.Services.Abstractions;
using Store.G04.Khaled.Services.Abstractions.Orders;
using Store.G04.Khaled.Services.Abstractions.Products;
using Store.G04.Khaled.Services.Orders;
using Store.G04.Khaled.Services.Payments;
using Store.G04.Khaled.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Products
{
    public class ServiceManager(IUnitOfWork _unitOfWork, 
        IMapper _mapper, 
        IBasketRepository _basketRepository, 
        ICacheRepository _cacheRepository, 
        UserManager<AppUser> userManager,
        IOptions<JwtOptions> options,
        IConfiguration configuration
        ) : IServiceManager
    {
        public IProductService ProductService { get; } = new ProductService(_unitOfWork, _mapper);
        public IBasketService BasketService { get; } = new BasketService(_basketRepository, _mapper);
        public ICacheService CacheService { get; } = new CacheService(_cacheRepository);
        public IAuthService AuthService { get; } = new AuthService(userManager, options, _mapper);

        public IOrderService OrderService { get; } = new OrderService(_unitOfWork, _mapper, _basketRepository);

        public IPaymentService PaymentService { get; } = new PaymentService(_basketRepository, _unitOfWork, configuration, _mapper);
    }
}
