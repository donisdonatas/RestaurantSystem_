using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AudiCar : Car
    {
        bool isQuatro { get; set; }

        public AudiCar(string model, bool isQ, int fuel)
        {
            Model = model;
            isQuatro = isQ;
            Fuel = fuel;
        }
    }
}
