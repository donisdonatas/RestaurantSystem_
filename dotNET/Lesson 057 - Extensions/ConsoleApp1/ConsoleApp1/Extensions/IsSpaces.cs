using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class IsSpaces
    {
        public static bool isSpaces(this string str)
        {
            return str.Contains(" ");
        }
    }
}
