using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example4
{
    public class PremiumClient : IClient
    {
        public string Name { get; set; }

        public decimal GetDiscount(decimal totalPrice)
        {
            return totalPrice * 0.25m;
        }
    }
}
