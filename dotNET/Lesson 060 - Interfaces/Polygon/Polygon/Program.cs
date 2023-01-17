using Polygon.Classes;
using Polygon.IComparers;
using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPolygon> polygons = new List<IPolygon>() { new Hexagon(12), new Hexagon(9), new Pentagon(36, 6), new Pentagon(35, 7), new Triangle(20, 9), new Quadrilateral(9), new Triangle(15, 8) };
            AreaComparer areaComparer = new AreaComparer();
            polygons.Sort(areaComparer);

            foreach(IPolygon polygon in polygons)
            {
                Console.WriteLine($"{polygon.GetType().Name} - {polygon.GetArea()}");
            }

            List<IWriteableToFile> Hexagons = new List<IWriteableToFile>() { new Hexagon(8), new Hexagon(9), new Hexagon(10), new Hexagon(11), new Hexagon(12)};
            foreach(IWriteableToFile hexagon in Hexagons)
            {
                hexagon.WriteToFile("hexsagons.txt");
            }

            Console.ReadLine();
        }
    }
}
