using Store.G04.Khaled.Shared;
using Store.G04.Khaled.Shared.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Abstractions.Products
{
    public interface IProductService
    {
        Task<PaginationResponse<ProductResponse>> GetAllProductsAsync(ProductQueryParameters parameters);
        Task<ProductResponse> GetProductByIdAsync(int id);
        Task<IEnumerable<BrandTypeResponse>> GetAllBrandsAsync();
        Task<IEnumerable<BrandTypeResponse>> GetAllTypeAsync();
    }
}
