using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();

            I2DShape circle2d = circle;
            I3DShape circle3d = circle;

            circle2d.Draw();
            circle3d.Draw();
        }
    }
}
