using Store.G04.Khaled.Services.Abstractions.Orders;
using Store.G04.Khaled.Services.Abstractions.Products;
using Store.G04.Khaled.Services.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Abstractions
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        IBasketService BasketService { get; }
        ICacheService CacheService { get; }
        IAuthService AuthService { get; }
        IOrderService OrderService { get; }
        IPaymentService PaymentService { get; }
    }
}
