using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example4
{
    public interface IClient    
    {
        string Name { get; set; }

        decimal GetDiscount(decimal totalPrice);
    }
}
