using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.G04.Khaled.Services.Abstractions;
using Store.G04.Khaled.Services.Mapping.Auth;
using Store.G04.Khaled.Services.Mapping.Orders;
using Store.G04.Khaled.Services.Mapping.Products;
using Store.G04.Khaled.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Products
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddAutoMapper(M => M.AddProfile(new ProductProfile(configuration)));
            services.AddAutoMapper(M => M.AddProfile(new BasketProfile()));
            services.AddAutoMapper(M => M.AddProfile(new OrderProfile()));
            services.AddAutoMapper(M => M.AddProfile(new AuthProfile()));
            services.Configure<JwtOptions>(configuration.GetSection("JwtOptions"));
            return services;
        }
    }
}
