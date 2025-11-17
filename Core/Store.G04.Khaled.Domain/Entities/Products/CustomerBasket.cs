using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Domain.Entities.Products
{
    public class CustomerBasket
    {
        public string Id { get; set; }
        public IEnumerable<BasketItem> Items { get; set; }
        public int? DeliveryMethodId { get; set; }
        public string? PaymentintentId { get; set; }
        public string? ClientSecret { get; set; }
        public decimal? ShipingCost { get; set; }
    }
}
