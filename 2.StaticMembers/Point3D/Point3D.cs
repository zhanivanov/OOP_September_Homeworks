using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        return String.Format("Point3D(X={0}, Y={1}, Z={2})",
            this.X,this.Y,this.X);
    }
}