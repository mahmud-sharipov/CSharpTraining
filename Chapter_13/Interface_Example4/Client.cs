using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example4
{
    public class Client : IClient
    {
        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public decimal GetDiscount(decimal totalPrice)
        {
            return totalPrice * 0.01m;
        }
    }
}
