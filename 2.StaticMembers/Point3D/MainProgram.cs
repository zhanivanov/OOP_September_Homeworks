using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MainProgram
{
    static void Main()
    {
        Point3D p = new Point3D(-7, -4, 3);
        Console.WriteLine(p);
        Point3D q = new Point3D(17, 6, 2.5);
        Console.WriteLine(q);
        Console.WriteLine(DistanceCalculator.CalcDistance(p, q));

        Path path = new Path(p, q, Point3D.StartingPoint);
        path.WriteToFile("path.txt");

        Path pathFromFIle = Path.ReadFromFile("path.txt");
        Console.WriteLine(pathFromFIle);

    }
}