using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.IComparers
{
    public class AreaComparer : IComparer<IPolygon>
    {
        public int Compare(IPolygon x, IPolygon y)
        {
            return x.GetArea().CompareTo(y.GetArea());
        }
    }
}
