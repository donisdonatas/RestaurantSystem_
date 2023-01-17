using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilietavimo_sistema;

namespace Bilietavimo_sistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki, pasirinkite punktą iš meniu:");
            Console.WriteLine("[1] Parduoti bilietus");
            Console.WriteLine("[2] Kurti bilietus");
            
            for(; ;)
            {
                int meniuChoise = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (meniuChoise)
                {
                    case 1: 
                        Console.WriteLine("Bilietų pardavimas:");
                        Console.WriteLine("Pasirinkite bilietų tipą:");
                        break;
                    case 2:
                        Console.WriteLine("Kurti bilietus:");
                        Console.WriteLine("Pasirinkite bilietų tipą:");
                        CreateTickets();
                        break;
                    default: 
                        Console.WriteLine("Pasirinktas blogas meniu punktas.");
                        break;
                }
                if(meniuChoise == 1 || meniuChoise == 2)
                {
                    break;
                }
                else
                {
                    //Console.ReadLine();
                }
            }
            
        }
    }
}
