using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }

        public void Drive(bool isTankEmpty)
        {
            if(isTankEmpty)
            {
                Console.WriteLine("My Car goes: Wroom wroom wroom");
            }
            else
            {
                Console.WriteLine("My tank is empty. I can't go nowhere.");
            }
            
        }

        public void Refuel()
        {
            Console.WriteLine("Your tank refulled fully");
        }
    }
}
