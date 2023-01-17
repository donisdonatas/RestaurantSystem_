using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //task1();
            //task3();
            //task4();


            //task01();
            //task02();
            //task03();
            //task04();

            //task001();
            //task002();
            task003();

            Console.ReadLine();
        }
        static void task1()
        {
            Console.WriteLine("Užduotis Nr. 1");
            Console.WriteLine("Įveskite tris simbolius");
            string symb = Console.ReadLine();
            char[] chars = symb.ToCharArray();
            char[] chars2 = new char[chars.Length];
            int j = 0;
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                chars2[j] = chars[i];
                j++;
            }
            Console.WriteLine(chars2);
            {

            }
            Console.ReadLine();

        }

        static void task3()
        {
            Console.WriteLine("Užduotis Nr. 3");
            Console.WriteLine("Įveskite rutulio diametrą:");
            float rd = float.Parse(Console.ReadLine());
            float pi = 3.141592f;
            double s = 4 * pi * Math.Pow(rd/2,2);
            double v = (4/3) * pi * Math.Pow(rd/2,3);
            Console.WriteLine($"Rutulio spindulys {rd/2}");
            Console.WriteLine("Rutulio plotas: {0}", s);
            Console.WriteLine("Rutulio tūris: {0}", v);
            Console.ReadLine();
        }

        static void task4()
        {
            Console.WriteLine("Užduotis Nr. 4");
            Console.WriteLine("Įveskite du skaičius, programa patikrins ar jie abu lyginiai:");
            int sk1 = int.Parse(Console.ReadLine());
            int sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sk1 % 2 == 0 && sk2 % 2 == 0 ? true : false);
            Console.ReadLine();
        }

        static void task01()
        {
            Console.WriteLine("Užduotis Nr. 01");
            Console.WriteLine("Įveskite bet kokį simbolį, programa nupieš simbolių trikampį:");
            string sym = Console.ReadLine();
            for(int i = 1; i <= 3; i++)
            {
                int j = 1;
                while(j <= i)
                {
                    Console.Write(sym);
                    j++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void task02()
        {
            Console.WriteLine("Užduotis Nr. 02");
            Console.WriteLine("Įveskite vartotojo vardą ir slaptažodį:");
            string realUserName = "Donatas";
            string realPassword = "pass";
            bool prisijungta = false;
            int i = 0;
            do {
                string userName = Console.ReadLine();
                string password = Console.ReadLine();
                if (realUserName != userName && realPassword != password)
                {
                    Console.WriteLine("Vartotojo vardas arba slaptažodis neteisingi!");
                }
                else
                {
                    Console.WriteLine("Prisijungta!");
                    prisijungta = true;
                }
                i++;
            } while(i < 3 && !prisijungta);
            if(i == 3)
            {
                Console.WriteLine("Jūs tris kartus įvedėt blogą slatažodį!");
            }
            Console.ReadLine();
        }

        static void task03()
        {
            Console.WriteLine("Užduotis Nr. 03");
            Console.WriteLine("Įveskite įveskite temperatūra Celcijaus laipsniais:");
            int tempC = int.Parse(Console.ReadLine());
            double tempF = (tempC * 1.8) +32;
            int tempK = 273 + tempC;
            Console.WriteLine("Farenheitai: {0}", tempF);
            Console.WriteLine("Kelvinai: {0}", tempK);

        }

        static void task04()
        {
            Console.WriteLine("Užduotis Nr. 04");
            Console.WriteLine("Įveskite didelį dešimtženklį skaičių:");
            double bigNumb = double.Parse(Console.ReadLine());
            int normalNumb = (int)bigNumb;
            short shortNumb = (short)bigNumb;
            byte byteNumb = (byte)bigNumb;
            Console.WriteLine("bigNumb: " + bigNumb);
            Console.WriteLine("normalNumb: " + normalNumb);
            Console.WriteLine("shortNumb: " + shortNumb);
            Console.WriteLine("byteNumb: " + byteNumb);
        }

        static void task001()
        {
            Console.WriteLine("Užduotis Nr. 001");
            Console.WriteLine("Įveskite grupės narių kiekį");

            int band = 0;
            
            if(!int.TryParse(Console.ReadLine(), out band))
            {
                Console.WriteLine("Įvestas nekorektiškas skaičius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if(band == 1)
            {
                Console.WriteLine("Tai solo atlikėjas");
            }
            else if(band == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if(band > 2 && band < 10) 
            {
                Console.WriteLine("Tai ansamblis");
            }
            else if(band >= 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
        }

        static void task002()
        {
            Console.WriteLine("Užduotis Nr. 002");
            Console.WriteLine("Įveskite išdirbtas valandas:");
            int workH = int.Parse(Console.ReadLine());
            if(workH < 160)
            {
                Console.WriteLine("Dar reikia išdirbti {0} valandas", 160 - workH);
            }
            else if(workH == 160)
            {
                Console.WriteLine("Išdirbtas pilnas etatas. Gali eiti ilsėtis");
            }
            else {
                Console.WriteLine("jau išdirbta {0} val viršvlandžių. Tau reikėtų pailsėti.", workH - 160);
            }
        }

        static void task003()
        {
            Console.WriteLine("Užduotis Nr. 003");
            Console.WriteLine("Įveskite egzamino pažymį:");
            int pazimys = int.Parse(Console.ReadLine());
            switch(pazimys)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine("Nepatenkinamai");
                    break;
                case 5: Console.WriteLine("Silpnai");
                    break;
                case 6: Console.WriteLine("Patenkinamai");
                    break;
                case 7: Console.WriteLine("Vidutiniškai");
                    break;
                case 8: Console.WriteLine("Gerai");
                    break;
                case 9: Console.WriteLine("Labai gerai");
                    break;
                case 10: Console.WriteLine("Puikiai");
                    break;
                default:
                    break;
            }
        }
    }
}
