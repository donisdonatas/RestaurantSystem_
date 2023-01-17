using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class FindEqual
    {
        public static bool FindAndReturnIfEqual<T>(this List<T> List, List<T> ListToCheck)
        {
            bool found = false;
            foreach(T item in List)
            {
                foreach(T item2 in ListToCheck)
                {
                    if (item2.Equals(item))
                    {
                        found = true;
                    }
                }
            }
            return found;
        }
    }
}
