using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Animals.Animals
{
    public class Bass : IAnimal, IFish
    {
        public string Name { get; }

        public Bass(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} - Niamy niamy");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming: Pliušku pliušku");
        }
    }
}
