using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Cat : IAnimal, IMammal
    {
        public string Name { get; }

        public Cat(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} - Niamu niamu");
        }

        public void GiveBirth()
        {
            Console.WriteLine($"New small {Name} Cat is Born");
        }
    }
}
