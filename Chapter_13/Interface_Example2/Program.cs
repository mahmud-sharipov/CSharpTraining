using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Cook(person);
            Drive(person);

            Worker worker = new Worker();
            Cook(worker);
            Drive(person);
        }

        static void Cook(ICook cook)
        {
            cook.Cook("");
        }

        static void Drive(IDriver driver)
        {
            driver.Drive();
        }
    }
}
