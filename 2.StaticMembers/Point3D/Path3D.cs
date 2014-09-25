using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Path
{
    private List<Point3D> points = new List<Point3D>();

    public Path(params Point3D[] points)
    {
        this.points = new List<Point3D>();
        this.points.AddRange(points);
    }


    public void WriteToFile(string fileName)
    {
        File.WriteAllText(fileName, this.ToString());
    }

    public static Path ReadFromFile(string fileName)
    {
        string pathStr = File.ReadAllText(fileName);
        Regex regex = new Regex(@"X=(.*?), Y=(.*?), Z=(.*?)\)");
        var matches = regex.Matches(pathStr);
        Path path = new Path();
        for (int i = 0; i < matches.Count; i++)
        {
            double x = Double.Parse(matches[i].Groups[1].Value);
            double y = Double.Parse(matches[i].Groups[2].Value);
            double z = Double.Parse(matches[i].Groups[3].Value);
            Point3D point = new Point3D(x, y, z);
            path.points.Add(point);

        }
        return path;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Path { ");
        result.Append(string.Join(", ", this.points));
        result.Append("}");
        return result.ToString();
    }
}
