using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mokinys mokinys = new Mokinys();

            mokinys.trimestras_1.Add(5);
            mokinys.trimestras_1.Add(6);
            mokinys.trimestras_1.Add(7);
            mokinys.trimestras_1.Add(8);
            mokinys.trimestras_1.Add(6);
            mokinys.trimestras_1.Add(6);

            mokinys.trimestras_2.Add(9);
            mokinys.trimestras_2.Add(10);
            mokinys.trimestras_2.Add(7);
            mokinys.trimestras_2.Add(8);

            mokinys.trimestras_3.Add(9);
            mokinys.trimestras_3.Add(10);
            mokinys.trimestras_3.Add(6);
            mokinys.trimestras_3.Add(6);


            float pirasTrimestras = mokinys.PirmoTrimestroVidurkis();
            float antrasTrimestras = mokinys.AntroTrimestroVidurkis();
            float treciasTrimestras = mokinys.TrecioTrimestroVidurkis();

            Console.WriteLine("Pirmo trimestro vidurkis: " + pirasTrimestras);
            Console.WriteLine("Antro trimestro vidurkis: " + antrasTrimestras);
            Console.WriteLine("Trečio trimestro vidurkis: " + treciasTrimestras);
            
            Console.ReadLine();
        }
    }
}
