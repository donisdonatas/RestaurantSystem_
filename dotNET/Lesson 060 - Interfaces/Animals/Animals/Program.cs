using Animals.Animals;
using Animals.Comparers;
using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IAnimal> animals = new List<IAnimal>() { new Dog("Baksis"), new Dog("Amsis"), new Cat("Murkis"), new Bass("Kašalotas"), new Carp("Žvynius") };
            List<IMammal> mammals = new List<IMammal>() { new Dog("Taksis"), new Cat("Meškis"), new Dog("Lesė"), new Dog("Reksis"), new Cat("Murkis") };
            List<IFish> fish = new List<IFish>() { new Bass("Grobuonis"), new Carp("Dumblinis") };

            foreach (IAnimal a in animals)
            {
                a.Eat();
            }

            foreach (IMammal m in mammals)
            {
                m.GiveBirth();
            }

            foreach(IFish f in fish)
            {
                f.Swim();
            }

            Console.WriteLine("------------");
            Console.WriteLine("Žinduolių išrūšiavimas, pagal vardą:");

            MammalsComparer mammalComparer = new MammalsComparer();
            mammals.Sort(mammalComparer);

            foreach(IMammal m in mammals)
            {
                Console.WriteLine(m.Name);
            }



            Console.WriteLine("------------");
            Console.WriteLine("Interfeisai testas:");

            var type = typeof(IAnimal);
            const BindingFlags flags = BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Instance;
            var methods = type.GetMethods(flags);
            foreach (var method in methods) Console.WriteLine(method);



            Console.WriteLine(type);
            //foreach(IAnimal i in Interfaces)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(typeof(List<IAnimal>).GetInterfaces());

            Console.ReadLine();
        }
    }
}
