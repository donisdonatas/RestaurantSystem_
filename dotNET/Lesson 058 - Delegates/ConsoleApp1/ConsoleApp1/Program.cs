using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate string getFullPersonInfo(string fn, string ln, int a);
        public delegate int getPersonsYearOfBirth(int a, int b);
        public delegate List<int> getNumbersByStep(List<int> month, int step);
        public delegate string GetTypeOfT<T>(T element);
        static void Main(string[] args)
        {
            
            
            Person my = new Person();
            getFullPersonInfo fullInfo = my.getFullNameAndAge;
            string result = fullInfo("Donatas", "Raudonis", 39);
            Console.WriteLine(result);

            getPersonsYearOfBirth birthYear = my.yearOfBirth;
            int personBirth = birthYear(39, 2022);
            Console.WriteLine($"Person birth is: {personBirth} year");

            getNumbersByStep numbersByStep = my.getNumbersByStep;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbers2 = numbersByStep(numbers, 3);

            foreach(int number in numbers2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();


            Generic<object> generic = new Generic<object>();
            GetTypeOfT<object> getType = new GetTypeOfT<object>(generic.GetType);
            string type = getType(5);
            string type2 = getType("stringas");
            Console.WriteLine($"Value type is: {type}");
            Console.WriteLine($"Value type is: {type2}");


            Console.ReadLine();
        }
    }
}
