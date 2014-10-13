using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphism
{
    class Triangle : BasicShape
    {
        private double c;

        public Triangle(double a, double b, double c) : base(a, b)
        {
            this.C = c;
        }

        public double C
        {
            get { return this.c; }
            set
            {
                if(checkTriangle(this.Width, this.Height, value))
                {
                    this.c = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public bool checkTriangle(double a, double b, double c)
        {
            if(a + b > c &&
                a + c > b &&
                b + c > a)
            {
                return true;
            }

            return false;
        }

        public override double CalculatePerimeter()
        {
            return this.Height + this.Width + this.C;
        }
    }
}
