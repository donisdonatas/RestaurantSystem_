using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class NegativeOrPositive
    {
        public static bool isPositive(this int integer)
        {
            return integer > 0 ? true : false;
        }
    }
}
