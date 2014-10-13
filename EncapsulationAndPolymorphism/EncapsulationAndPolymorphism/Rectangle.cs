using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphism
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
