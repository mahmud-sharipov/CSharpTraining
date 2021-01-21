using System;

namespace Interface_Example2
{
    public class Person : IDriver, ICook
    {
        public void Cook(string food)
        {
            Console.WriteLine("Cooking " + food);
        }

        public void Drive()
        {
            Console.WriteLine("Driving car");
        }
    }
}
