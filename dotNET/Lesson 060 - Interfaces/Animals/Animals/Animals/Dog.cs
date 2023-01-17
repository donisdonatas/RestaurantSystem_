using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Dog : IAnimal, IMammal
    {
        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} - Niame niame");
        }

        public void GiveBirth()
        {
            Console.WriteLine($"New small {Name} Dog is Born");
        }
    }
}
