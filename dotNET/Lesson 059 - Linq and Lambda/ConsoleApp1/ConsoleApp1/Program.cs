using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Pavyzdžio testas:");
            //Func<string, string> selector = str => str.ToUpper();
            //string[] words = { "orange", "apple", "Article", "elephant" };
            //IEnumerable<string> wordsEnum = words.Select(selector);
            ////string[] upperWords = words.Select(selector);   //Šitos vietos string[] nesuprato

            //foreach(string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            
            //Console.WriteLine("--------------");
            //foreach (string eWord in wordsEnum)
            //{
            //    Console.WriteLine(eWord);
            //}

            //Func<int, double> selector1 = sk => Math.Pow(sk, 2);      //Galima panaudoti ir šitą parašymą, arba tiesioginį metodą įrašant į sklaustus tai kas eina po lygybės
            int[] skaiciai = { -5, -15, 7, 8, 56, -14, -20, 14, 54, 32 };
            IEnumerable<double> skaiciai1 = skaiciai.Select(sk => Math.Pow(sk, 2));
            Console.WriteLine("Skaičiai pakelti kvadratu:");
            foreach (double skaicius in skaiciai1)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine("--------------");
            IEnumerable<int> teigiami = skaiciai.Where(sk => sk > 0);
            Console.WriteLine("Teigiami skaičiai:");
            foreach (int skaicius in teigiami)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine("--------------");
            IEnumerable<int> teigiamiNeDidesniUz10 = skaiciai.Where(sk => sk > 0 && sk < 10);
            Console.WriteLine("Teigiami skaičiai mažesnis už 10:");
            foreach (int skaicius in teigiamiNeDidesniUz10)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine("--------------");
            IEnumerable<int> didejantysSkaiciai = skaiciai.OrderBy(sk => sk);
            Console.WriteLine("Skaičiai didėjančia tvarka:");
            foreach (int skaicius in didejantysSkaiciai)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine("--------------");
            IEnumerable<int> mazejantysSkaiciai = skaiciai.OrderBy(sk => sk).Reverse();
            Console.WriteLine("Skaičiai mažėjančia tvarka:");
            foreach (int skaicius in mazejantysSkaiciai)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine("--------------");
            int didziausiasSkaicius = skaiciai.OrderBy(sk => sk).Last();
            Console.WriteLine("Didžiausias skaičius:");
            Console.WriteLine(didziausiasSkaicius);

            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Person List = new Person();
            List.CreatePersonsList();

            List<Person> personsList = List.Persons;
            IEnumerable<string> names = personsList.Select(pl => pl.Name);
            Console.WriteLine("Žmonių vardai:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------");
            IEnumerable<int> ages = personsList.Select(pl => pl.Age);
            Console.WriteLine("Žmonių amžius:");
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine("--------------");
            IEnumerable<Person> descendingList = personsList.OrderBy(pl => pl.Age).Reverse();
            Console.WriteLine("Žmonių amžius mažėjančia tvarka:");
            foreach (Person person in descendingList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("--------------");
            IEnumerable<Person> onlyAnames = personsList.Where(pl => pl.Name.StartsWith("A"));
            Console.WriteLine("Žmonių sąrašas, kurių vardai prasideda raide - A:");
            foreach (Person person in onlyAnames)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.WriteLine("--------------");
            IEnumerable<Person> personsAbove40 = personsList.Where(pl => pl.Age > 40).OrderBy(pl => pl.Name);
            Console.WriteLine("Žmonių sąrašas kuriems virš 40 metų, abėcėlės tvarka:");
            foreach (Person person in personsAbove40)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            Console.ReadLine();


        }
    }
}
