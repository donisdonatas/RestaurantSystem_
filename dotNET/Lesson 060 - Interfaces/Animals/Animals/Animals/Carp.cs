using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    public class Carp : IAnimal, IFish
    {
        public string Name { get; }

        public Carp(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} - Niam niam");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming: Pliušku pliušku");
        }
    }
}
