using Store.G04.Khaled.Domain.Entities.Orders;
using Store.G04.Khaled.Services.Specifications.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Services.Specifications.Orders
{
    public class OrderWithPaymentIntentSpecifications : BaseSpecifications<Guid, Order>
    {
        public OrderWithPaymentIntentSpecifications(string paymentIntentId) : base(O => O.PaymentIntentId == paymentIntentId)
        {
            
        }
    }
}
