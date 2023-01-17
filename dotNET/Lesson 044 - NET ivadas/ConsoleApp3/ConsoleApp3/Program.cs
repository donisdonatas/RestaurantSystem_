using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("Pratimas Nr. 1");
            string spalva = "";
            Console.WriteLine("Kokia tavo mėgstamiausia spalava?");
            spalva = Console.ReadLine();
            Console.WriteLine("Mano taip pat");
            Console.ReadLine();

            //2.
            Console.WriteLine("Pratimas Nr. 2");
            int a = 17;
            int b = 23;
            int c;
            c = 17 + 23;
            Console.WriteLine("17 + 23 = {0}", c);
            Console.ReadLine();

            //3.
            Console.WriteLine("Pratimas Nr. 3");
            int d = 24;
            int e = 5;
            decimal f;
            f = d / e;
            Console.WriteLine("24 / 5 = {0}", f);
            Console.ReadLine();
 
            //4.
            Console.WriteLine("Pratimas Nr. 4");
            int g = -6 + 3 * 5;
            int h = (13 - 2) * 7;
            double i = (5.0 + -2.0) + (10.0 / 20.0);
            Console.WriteLine("-6 + 3 * 5 = {0}", g);
            Console.WriteLine("(13 - 2) * 7 = {0}", h);
            Console.WriteLine("(5.0 + -2.0) + (10.0 / 20.0) = {0}", i);
            Console.ReadLine();

            //5.
            Console.WriteLine("Pratimas Nr. 5");
            Console.WriteLine("Įveskite skaičių (1/2):");
            int j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių (2/2):");
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = " + (j + k), j, k);
            Console.WriteLine("{0} - {1} = " + (j - k), j, k);
            Console.WriteLine("{0} * {1} = " + (j * k), j, k);
            Console.WriteLine("{0} / {1} = " + (j / k), j, k);
            Console.ReadLine();

            //6.
            Console.WriteLine("Pratimas Nr. 6");
            Console.WriteLine("Įveskite skaičių:");
            int l = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Daugybos lentelė:");
            for (int ii = 0; ii <= 10; ii++) {
                Console.WriteLine("{0} x {1} = {2}", ii, l, ii * l);
            }
            Console.ReadLine();

            //7.
            Console.WriteLine("Pratimas Nr. 7");
            int[] arr = new int[4];
            for(int kk = 0; kk < 4; kk++)
            {
                Console.WriteLine("Įveskite keturis skaičius {0}/4:", kk + 1);
                int aa = Int32.Parse(Console.ReadLine());
                arr[kk] = aa;
            }
            double avg = arr.Average(); //arr.Sum() / arr.Length;
            Console.WriteLine("Įvestų skaičių vidurkis: {0}", avg);
            Console.ReadLine();
        }

    }
}
