using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 1");
            ConvertToDouble convertToDouble = new ConvertToDouble();
            Console.WriteLine("=========");
            
            Console.WriteLine("Program 2");
            GFG gfg = new GFG();
            Console.WriteLine("=========");

            Console.WriteLine("Program 3");
            PossibleErrors errors = new PossibleErrors();
            Console.WriteLine("=========");

            Console.WriteLine("Program 4");
            ReadFile readFile = new ReadFile();
            Console.WriteLine("=========");

            Console.ReadLine();
        }
    }
}
