using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2
{
    class Worker : ICook
    {
        public void Cook(string food)
        {
            Console.WriteLine("Worker is cooking");
        }
    }
}
