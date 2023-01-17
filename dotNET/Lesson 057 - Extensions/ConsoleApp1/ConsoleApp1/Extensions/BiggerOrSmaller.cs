using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class BiggerOrSmaller
    {
        public static bool isBiggerThan(this int integer, int value)
        {
            return integer > value;
        }
    }
}
