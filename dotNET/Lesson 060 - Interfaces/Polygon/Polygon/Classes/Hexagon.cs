using Polygon.IComparers;
using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Polygon.Classes
{
    public class Hexagon : IPolygon, IWriteableToFile
    {
        public double Side;
        public double Area;

        public Hexagon(double side)
        {
            Side = side;
        }
        public double GetArea()
        {
            Area = (3 * Math.Sqrt(3) * Math.Pow(Side, 2)) / 2;
            return Area;
        }

        public override string ToString()
        {
            string PolygonName = this.GetType().Name;
            string ObjectInString = $"This is {PolygonName}. It's Area is {this.GetArea()}";
            return ObjectInString;
        }

        public void WriteToFile(string fileName)
        {
            string SolutionPath = Path.GetFullPath(Directory.GetCurrentDirectory());
            string FileLocation = @"..\..\..\";
            string FilePath = Path.Combine(SolutionPath, FileLocation, fileName);

            using (StreamWriter streamWriter = File.AppendText(FilePath))
            {
                streamWriter.WriteLine(this.ToString());
            }
        }
    }
}
