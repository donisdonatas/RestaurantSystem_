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
            Person person1 = new Person();
            person1.PersonName = "Audrey";

            person1.Animals = new List<Animal>();
            person1.Animals.Add(new Animal());

        }
    }
}
