using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilietavimo_sistema
{
    public class TicketingSystem
    {
        //Metodai:
        //Sell Tickets
        //Create Tickets
        //ir t.t. visi metodai susiję su bilietais

        public void CreateTickets()
        {
            Console.WriteLine("Pasirinkite bilietų rūšį sukūrimui");
            Console.WriteLine("[1] po 10 Eur");
            Console.WriteLine("[2] po 20 Eur");
            Console.WriteLine("[3] po 30 Eur");
            int ticketType = int.Parse(Console.ReadLine());
            Console.WriteLine("Įrašykite, kokį kiekį norite sukurti");
            int ticketCount = int.Parse(Console.ReadLine());
            CreateTickets(ticketType, ticketCount);
        }
    }
}
