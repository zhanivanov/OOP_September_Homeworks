using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndPolymorphism
{
    class MainClass
    {
        static void Main()
        {
            IShape triangle = new Triangle(20, 20, 20);
            IShape rectangle = new Rectangle(10, 11);
            IShape circle = new Circle(5);
            IShape[] shapes = {triangle, rectangle, circle};

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType() + "\n" + item.CalculateArea() + "\n" + item.CalculatePerimeter() + "\n");
            }
        }
    }
}
