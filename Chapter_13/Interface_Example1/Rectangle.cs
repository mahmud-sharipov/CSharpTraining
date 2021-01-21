using System;

namespace Interface_Example1
{
    public class Rectangle : IShape
    {
        public Rectangle(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
