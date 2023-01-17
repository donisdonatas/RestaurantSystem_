using Struct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mokinys();
            //Biblioteka();
            //Plotas();
            //Studentas();
            Console.ReadLine();
        }

        static void Mokinys()
        {
            Mokinys mokinys = new Mokinys("Saulius", "Urbonas", 2022, 2023);

            Console.WriteLine(mokinys.firstName);
            Console.WriteLine(mokinys.lastName);
            Console.WriteLine(mokinys.startOfCourses);
            Console.WriteLine(mokinys.finishOfCourses);
            Console.ReadLine();
        }

        static void Biblioteka()
        {
            Biblioteka knyga = new Biblioteka(125, "Laimės knyga", "Donatas", 2);

            Console.WriteLine(knyga.getSienceBookTaken(3));
        }

        static void Plotas()
        {
            Staciakampis figura = new Staciakampis(5, 6);
            Console.WriteLine(figura.getArea());
        }

        static void Studentas()
        {
            List<Studentas> studentai = new List<Studentas>();
            
            studentai.Add(new Studentas(1, true));
            studentai.Add(new Studentas(2, false));
            Console.WriteLine(studentai.Count);

            foreach(Studentas student in studentai)
            {
                Console.WriteLine(student.id + ": " + student.creditScore);
            }
        }

        public void Pazymiu_Kngele()
        {

        }
    }
}
