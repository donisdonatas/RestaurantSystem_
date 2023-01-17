using ConsoleApp1.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Įrašykite sveikąjį skaičių");
            //int skaicius = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skaičius yra teigiamas: " + skaicius.isPositive());
            //Console.WriteLine("Skaičius yra lyginis: " + skaicius.isEven());
            //Console.WriteLine("Skaičius yra didesnis už 100: " + skaicius.isBiggerThan(100));
            //Console.WriteLine();

            //Console.WriteLine("Įrašykite frazę");
            //string str = Console.ReadLine();
            //Console.WriteLine("Frazė turi tarpų: " + str.isSpaces());
            //Console.WriteLine();

            //Console.WriteLine("Įrašykite savo vardą:");
            //string fullName = Console.ReadLine();
            //Console.WriteLine("Įrašykite savo gimimo metus:");
            //int yearOfBirth = int.Parse(Console.ReadLine());
            //Console.WriteLine("Įrašykite domeno adresą:");
            //string domain = Console.ReadLine();
            //Console.WriteLine("Jūms sukurtas naujas pašto adresas: " + fullName.CreateEmail(yearOfBirth, domain));
            //Console.WriteLine();


            //List<string> primeList = new List<string>() { "stalas", "kėdė", "suolas", "parašiutas", "kaitlentė" };
            //List<string> checkList = new List<string>() { "saulė" , "kėdė"};
            //Console.WriteLine("Sąrašas yra pirminime sąraše: " + primeList.FindAndReturnIfEqual(checkList));

            //Console.WriteLine("Sutrumpintas sąrašas:");
            //foreach (string prime in primeList.EveryOtherWord())
            //{
            //    Console.WriteLine(prime);
            //}
            //Console.WriteLine();


            //ReadFile readFile = new ReadFile();
            string filePath = @"H:\Shared drives\MG donisdonatas@gmail.com\Code Academy\Paskaitos\dotNET\Lesson 056 - Error Handling\ConsoleApp1\ConsoleApp1\CompanysList.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            List<string> everyOtherLine = fileInfo.readEveryOtherLine(false);
            foreach(var line in everyOtherLine)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
