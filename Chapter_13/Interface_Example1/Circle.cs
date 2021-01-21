using System;

namespace Interface_Example1
{
    public class Circle : IShape
    {
        public Circle(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
