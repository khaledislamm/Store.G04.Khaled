using Microsoft.AspNetCore.Mvc;
using Store.G04.Khaled.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController(IServiceManager _serviceManager) : ControllerBase
    {
        // create paymentIntent
        [HttpPost("{basketId}")]
        public async Task<IActionResult> CreatePaymentIntent(string basketId)
        { 
            
            var result = await _serviceManager.PaymentService.CreatePaymentIntentAsync(basketId);
            return Ok(result);
        }
    }
}
