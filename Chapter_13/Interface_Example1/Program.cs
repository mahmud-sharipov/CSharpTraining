using System;

namespace Interface_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle");
            IShape rectangle = new Rectangle("Rectangle");

            DrawShape(circle);
            DrawShape(rectangle);

            Console.ReadLine();
        }

        static void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
