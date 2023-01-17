using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Classes
{
    public class Quadrilateral : IPolygon
    {
        public double Border;
        public double Area;

        public Quadrilateral(double border)
        {
            Border = border;
        }
        public double GetArea()
        {
            Area = Border * Border;
            return Area;
        }
    }
}
