using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Classes
{
    public class Triangle : IPolygon
    {
        public double Height;
        public double Width;
        public double Area;

        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            Area = (Height * Width) / 2;
            return Area;
        }
    }
}
