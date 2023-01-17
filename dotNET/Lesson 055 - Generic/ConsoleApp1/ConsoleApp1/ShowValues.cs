using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ShowValues<T1, T2>
    {
        public void Print(T1 element1, T2 element2)
        {
            Console.WriteLine(element1);
            Console.WriteLine(element2);
        }
    }
}
