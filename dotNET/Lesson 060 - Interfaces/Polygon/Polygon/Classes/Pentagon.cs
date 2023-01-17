using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Classes
{
    public class Pentagon : IPolygon
    {
        public double Perimeter;
        public double Apothem;
        public double Area;

        public Pentagon(double perimeter, double apothem)
        {
            Perimeter = perimeter;
            Apothem = apothem;
        }

        public double GetArea()
        {
            Area = (Perimeter * Apothem) / 2;
            return Area;
        }
    }
}
