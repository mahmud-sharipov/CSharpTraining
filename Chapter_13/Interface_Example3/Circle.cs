using System;

namespace Interface_Example3
{
    public class Circle : I2DShape, I3DShape
    {
        public string Name { get; set; }

        void I2DShape.Draw()
        {
            Console.WriteLine("Drawing 2D circle");
        }

        void I3DShape.Draw()
        {
            Console.WriteLine("Drawing 3D circle");
        }
    }
}
