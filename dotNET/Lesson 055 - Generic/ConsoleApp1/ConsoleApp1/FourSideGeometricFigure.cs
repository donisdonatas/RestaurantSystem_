using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FourSideGeometricFigure
    {
        public string Name = "Rectangle";
        public int Base = 5;
        public int Height = 7;

        public int GetArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            string thisFigure = $"Name: {Name}, Base: {Base}, Height: {Height}, Area: {GetArea()}";
            return thisFigure;
        }
    }
}
