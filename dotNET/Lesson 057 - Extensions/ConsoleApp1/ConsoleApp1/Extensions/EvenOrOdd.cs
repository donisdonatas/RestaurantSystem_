using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class EvenOrOdd
    {
        public static bool isEven(this int integer)
        {
            return integer % 2 == 0 ? true : false;
        }
    }
}
