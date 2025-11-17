using Microsoft.AspNetCore.Mvc;
using Store.G04.Khaled.Services.Abstractions;
using Store.G04.Khaled.Shared.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController(IServiceManager serviceManager) : ControllerBase
    {
        [HttpGet] // GET: /api/baskets?id=sadas
        public async Task<IActionResult> GetBasketId(string id)
        {
            var result = await serviceManager.BasketService.GetBasketAsync(id);
            return Ok(result);
        }

        [HttpPost] // Post: /api/Baskets
        public async Task<IActionResult> UpdateBasket(BasketDto basketDto)
        {
            var result = await serviceManager.BasketService.UpdateBasketAsync(basketDto);
            return Ok(result);
        }

        [HttpDelete] // Delete : /api/baskets?id
        public async Task<IActionResult> DeleteBasket(string id)
        {
            await serviceManager.BasketService.DeleteBasketAsync(id);
            return NoContent(); //204
        }
    }
}
