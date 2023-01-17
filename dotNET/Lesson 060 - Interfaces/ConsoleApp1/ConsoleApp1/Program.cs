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
            //AudiCar audi = new AudiCar("A4", false, 65);
            List<AudiCar> audiCars = new List<AudiCar> { new AudiCar("A4", false, 65), new AudiCar("A6", true, 70), new AudiCar("Q5", true, 80) };

            CarComparer carComparer = new CarComparer();

            audiCars.Sort(carComparer);

            //audi.Drive(false);
            //audi.Refuel();
            //audi.Drive(true);

            Console.ReadLine();

        }
    }
}
