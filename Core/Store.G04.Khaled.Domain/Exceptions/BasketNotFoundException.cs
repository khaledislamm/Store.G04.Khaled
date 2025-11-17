using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Domain.Exceptions
{
    public class BasketNotFoundException(string id) 
        : NotFoundException($"Basket With Id {id} Not Found")
    {

    }
}
