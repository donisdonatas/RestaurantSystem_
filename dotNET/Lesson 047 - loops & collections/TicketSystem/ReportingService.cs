using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem
{
    internal class ReportingService
    {
        TicketRepository ticketRepository;

        public ReportingService(TicketRepository ticketRepository) 
        {
            this.ticketRepository = ticketRepository;
        }

        public void ReportByStatus()
        {
            foreach(TicketStatus status in Enum.GetValues(typeof(TicketStatus)))
            {
                List <Ticket> ticketsByStatus = this.ticketRepository.GetTicketsByStatus(status);
                Console.WriteLine("");
                Console.WriteLine($"Tickets count with status {status}: {ticketsByStatus.Count}\n");
            }
        }
    }
}
