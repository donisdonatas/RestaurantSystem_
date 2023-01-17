using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem
{
    internal class TicketingService
    {

        TicketRepository ticketRepository; //naudojamas kam?

        public TicketingService(TicketRepository ticketRepository) {    //constructor - gaunu ticket repository lista?
            this.ticketRepository = ticketRepository;
        }

        public void CreateTicket(TicketType ticketType, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                ticketRepository.AddTicket(new Ticket(ticketType));
            }
        }

        public bool BuyTicket(TicketType ticketType, int quantity)
        {
            List<Ticket> availableTickets = ticketRepository.GetAvailableTicketsOfType(ticketType);
            if (availableTickets.Count >= quantity)
            {
                for (int i = 0; i < quantity; i++)
                {
                    availableTickets[i].SetSold();
                }

                return true;
            } else
            {
                Console.WriteLine("\nNot enough tickets of this type! Sorry...\n");
                return false;
            }
        }
    }
}
