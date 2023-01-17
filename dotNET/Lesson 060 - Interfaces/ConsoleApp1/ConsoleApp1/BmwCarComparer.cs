using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BmwCarComparer : IComparer<BMWCar>
    {
        public int Compare(BMWCar x, BMWCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
