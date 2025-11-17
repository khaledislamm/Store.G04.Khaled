using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.G04.Khaled.Domain.Exceptions
{
    public class CreateOrderBadRequestException() : BadRequestException("Invalid Operation When Create Order !!")
    {
    }
}
