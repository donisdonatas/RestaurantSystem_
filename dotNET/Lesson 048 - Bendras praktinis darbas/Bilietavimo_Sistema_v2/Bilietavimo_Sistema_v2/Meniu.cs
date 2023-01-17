using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilietavimo_Sistema_v2.Models;


namespace Bilietavimo_Sistema_v2
{
    internal class Meniu
    {
        public void getMainMeniu()
        {

            Console.WriteLine("Pasirinkite meniu punktą:");
            Console.WriteLine("[1] Sukurti bilietus");
            Console.WriteLine("[2] Pirkti bilietus");
            Console.WriteLine("[3] Ataskaitos");
            Console.WriteLine("[4] Išeiti iš programos");

            int meniuItem = int.Parse(Console.ReadLine());

            switch(meniuItem)
            {
                case 1:
                    Console.WriteLine("Bilietų kūrimo langas:");
                    break;
                default: 
                    Console.WriteLine("Meniu nėra tokio punkto");
                    break;
            }
                 }
    }
}
