using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Method<T1, T2>
    {
        public T1 param1;
        public T2 param2;
        //public T3 param3;
        public Method(T1 arg1, T2 arg2)
        {
            param1 = arg1;
            param2 = arg2;
        }

        public void PrintT1()
        {
            Console.WriteLine($"Dabar spausdinamas param1: {param1}");
        }

        public void PrintT2()
        {
            Console.WriteLine($"Dabar spausdinamas param2: {param2}");
        }

        public T1 ChangeT1Value(T1 newParam1)
        {
            param1 = newParam1;
            return param1;
        }

        public T2 ChangeT2Value(T2 newParam2)
        {
            param2 = newParam2;
            return param2;
        }
    }
}
