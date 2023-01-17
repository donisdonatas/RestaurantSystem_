using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Type<T1, T2>
    {
        public T1 param1;
        public T2 param2;

        public void GetType(T1 input)
        {
            Console.WriteLine($"param1 duomenų tipas yra - {typeof(T1)}");
        }
    }
}
