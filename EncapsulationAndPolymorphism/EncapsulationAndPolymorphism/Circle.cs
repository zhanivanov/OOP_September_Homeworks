using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphism
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        double IShape.CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        double IShape.CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
