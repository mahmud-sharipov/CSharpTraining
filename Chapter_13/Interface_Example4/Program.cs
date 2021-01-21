using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Client 1");
            var premiumClient = new PremiumClient();
            var client2 = new OneTimeClient();

            PrintCheck(100, client);
            PrintCheck(100, premiumClient);
            PrintCheck(100, client2);

            Console.ReadLine();
        }

        static void PrintCheck(decimal totalPrice, IClient client)
        {
            Console.WriteLine(totalPrice - client.GetDiscount(totalPrice));
        }
    }
}
