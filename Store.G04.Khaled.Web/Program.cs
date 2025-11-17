
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.G04.Khaled.Domain.Contracts;
using Store.G04.Khaled.persistence;
using Store.G04.Khaled.persistence.Data.Contexts;
using Store.G04.Khaled.Services;
using Store.G04.Khaled.Services.Abstractions;
using Store.G04.Khaled.Services.Mapping.Products;
using Store.G04.Khaled.Shared.ErrorsModels;
using Store.G04.Khaled.Web.Extensions;
using Store.G04.Khaled.Web.Middlewares;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.RegisterAllServices(builder.Configuration);


            var app = builder.Build();



            await app.ConfigureMiddlewares();

            app.Run();
        }
    }
}
